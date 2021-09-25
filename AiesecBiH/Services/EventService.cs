using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.HelperModels;
using AiesecBiH.IServices;
using AiesecBiH.Model.Response;
using AiesecBiH.Services.BaseServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.Services
{
    public class EventService: CRUDService<Model.Response.Event,Database.Event, Model.Search.Event, Model.Update.Event, Model.Insert.Event>,IEventService
    {
        public static MLContext mlContext = null;
        private readonly AiesecContext _dbContext;
        private static readonly uint[] TimeOfDayUids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; // => Starts at 8 AM and every iteration is an hour to add

        public EventService(AiesecContext context,IMapper mapper):base(context,mapper)
        {
            _dbContext = context;
        }
        public async override Task<Event> Insert(Model.Insert.Event request)
        {
            Database.Event entity = _mapper.Map<Database.Event>(request);
            _dbContext.Events.Add(entity);
            await _dbContext.SaveChangesAsync();

            await AddAndTrainModel(new FunctFieldEventTimeModel
            {
                FunctionalFieldId = (uint)entity.FunctionalFieldId,
                EventTimeUid = GetVrijemeUid(entity.DateTime.Hour)
            });

            return _mapper.Map<Model.Response.Event>(entity);

        }

        public async Task<EventAttendance> Attend(int id, int memberId)
        {
            Database.EventAttendance request = new Database.EventAttendance
            {
                EventId = id,
                MemberId = memberId,
                Attended = true,
                CreatedDate=DateTime.Now
            };
            await _context.EventAttendances.AddAsync(request);
            await _context.SaveChangesAsync();
            return _mapper.Map<Model.Response.EventAttendance>(request);
        }

        public override async Task<IEnumerable<Model.Response.Event>> Get([FromQuery] Model.Search.Event search = null)
        {
            var query = _context.Events.AsQueryable();
            if (search?.InPast == false)
            {
                query = query.Where(x => DateTime.Compare(x.DateTime,DateTime.Now)>0);
            }
            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name));
            }
            if (search?.onlyActive != null && search.onlyActive == true)
            {
                query = query.Where(x => x.Active == search.onlyActive);
            }
            if (search?.LocalCommitteeId != null && search?.LocalCommitteeId!=0 )
            {
                query = query.Where(x => x.LocalCommitteeId == search.LocalCommitteeId);
            }
            if (search?.FunctionalFieldId != null && search?.FunctionalFieldId != 0 )
            {
                query = query.Where(x => x.FunctionalFieldId == search.FunctionalFieldId);
            }
            query = query.Where(x => x.Id != 1);
            var entities = await query.Include(x=>x.FunctionalField).Include(x=>x.LocalCommittee).OrderByDescending(x=>x.DateTime).ToListAsync();
            var result = _mapper.Map<IEnumerable<Model.Response.Event>>(entities);
            return result;
        }

        public async Task<IEnumerable<Model.Response.EventAttendance>> GetAttendance(int id)
        {
           var result= await _context.EventAttendances.Where(x => x.EventId == id).Include(x => x.Member).ToListAsync();
            return _mapper.Map<IList<Model.Response.EventAttendance>>(result);
        }

        public bool isAttending(int eventId,int memberId)
        {
            var entity = _context.EventAttendances.Where(x => x.EventId == eventId && x.MemberId == memberId).FirstOrDefault();
            if(entity!=null)
                return true;
            else
                return false;
        }
        public async Task<DateTime> GetRecommendedEventTime(int functionalFieldId)
        {
            var recommendedHoursToAdd = await RecommendTimeforEvent(functionalFieldId);
            var dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(3).Day);
            dateTime = dateTime.AddHours(8);//Start of the day

            dateTime = dateTime.AddHours(recommendedHoursToAdd);
            
            return dateTime;
        }
        //====================RECOMMENDATION SYSTEM====================

        #region RecommendationSystem

        public async Task<uint> RecommendTimeforEvent(int functionalFieldId)
        {
            mlContext = new MLContext();
            ITransformer model = await CreateModel();

            var predictionResult = new List<Tuple<uint, float>>();
            var predictionEngine = mlContext.Model.CreatePredictionEngine<FunctFieldEventTimeModel, PredictionResult>(model);

            foreach (var Uid in TimeOfDayUids)
            {
                var prediction = predictionEngine.Predict(new FunctFieldEventTimeModel
                {
                    FunctionalFieldId = (uint)functionalFieldId,
                    EventTimeUid = Uid
                });

                predictionResult.Add(new Tuple<uint, float>(Uid, prediction.Score));
            }

            predictionResult = predictionResult.OrderByDescending(x => x.Item2).ToList(); //Highest score on top
            foreach (var predict in predictionResult)
            {
                if (predict != null)
                    Console.WriteLine($@"{predict.Item1} => {predict.Item2}");
            }

            Console.WriteLine();
            return predictionResult.First().Item1;
        }

        private async Task AddAndTrainModel(FunctFieldEventTimeModel toAdd)
        {
            await CreateModel(toAdd);
        }

        private async Task<ITransformer> CreateModel(FunctFieldEventTimeModel toAdd = null)
        {
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = nameof(FunctFieldEventTimeModel.FunctionalFieldId),
                MatrixRowIndexColumnName = nameof(FunctFieldEventTimeModel.EventTimeUid),
                LabelColumnName = "Label",
                LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                Alpha = 0.01,
                Lambda = 0.025
            };

            var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

            var dataFromDb = await _dbContext.Events.Select(x => new FunctFieldEventTimeModel
            {
                FunctionalFieldId =(uint) x.FunctionalFieldId,
                EventTimeUid = x.TimeUid
            }).ToListAsync();
            if (toAdd != null)
                dataFromDb.Add(toAdd);
            var dataView = mlContext.Data.LoadFromEnumerable(dataFromDb);

            var model = est.Fit(dataView);

            return model;
        }

        #endregion RecommendationSystem

        private static uint GetVrijemeUid(int hours)
        {
            return (uint)hours - 7;
        }

    }
}
