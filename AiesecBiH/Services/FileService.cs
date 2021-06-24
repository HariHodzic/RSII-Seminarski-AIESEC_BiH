using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AiesecBiH.EF;
using AiesecBiH.Model.Insert;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.Services
{
    public class FileService
    {
        public readonly AiesecContext _context;
        public readonly IMapper _mapper;
        public FileService(AiesecContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> SaveFile(FileModel request)
        {
            var entity = _mapper.Map<Database.FileModel>(request);
            await _context.FileModels.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
        //public async Task<Data.DTO.Response.FileModel> GetFile(int id)
        //{
        //    var file = await _context.Files.FirstOrDefaultAsync(x => x.Id == id);
        //    if (file == null) return null;
        //    return _mapper.Map<Data.DTO.Response.FileModel>(file);
        //}
        //public async Task DeleteFile(int id)
        //{
        //    var file = await _context.Files.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    _context.Files.Remove(file);
        //    await _context.SaveChangesAsync();
        //}
    }
}
