using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels.Requests
{
    public class NewEventViewModel : BaseViewModel
    {
        private readonly APIService _EventsService = new APIService("Events");
        public ICommand SaveCommand { get; set; }
        private DateTime recommendedTime;

        public NewEventViewModel()
        {
            GetRecommendedTime();
            dateTime = DateTime.Now.Date.Add(recommendedTime.TimeOfDay).AddDays(1);

            SaveCommand = new Command(async () => await SaveEventAsync());
        }
        private async Task GetRecommendedTime()
        {
            try
            {
                recommendedTime = await _EventsService.GetWithSingleQuery<DateTime>("RecommendTime", "FunctionalFieldId", APIService.LoggedUser.FunctionalFieldId.ToString());
                if (recommendedTime == null)
                {
                    recommendedTime = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Time recommendation doesn't work because of lack of inputs", "OK");
            }
        }

        public async Task SaveEventAsync()
        {
            if (!Validate())
            {
                return;
            }

            Model.Insert.Event request = new Model.Insert.Event
            {
                Name = Name,
                DateTime = dateTime,
                Description = Description,
                FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId,
                AllFunctionalFields=_allFuncFields,
                AllLocalCommittees=AllLCs
            };
            var result = await _EventsService.Insert<Model.Insert.Notice>(request);
            if (result != default(Model.Insert.Notice) && result != null)
            {

                await Application.Current.MainPage.DisplayAlert("Info", "Sucessfully created new Event", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Error", "OK");
            }

        }

        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private DateTime _dateTime;
        public DateTime dateTime
        {
            get { return _dateTime; }
            set { SetProperty(ref _dateTime, value); }
        }
        

        private bool _allFuncFields;
        public bool AllFuncFields
        {
            get { return _allFuncFields; }
            set { SetProperty(ref _allFuncFields, value); }
        }
        //Invite all local committees to event
        private bool _allLCs;
        public bool AllLCs
        {
            get { return _allLCs; }
            set { SetProperty(ref _allLCs, value); }
        }

        //VALIDATION
        private string _lblDescriptionError = string.Empty;
        public string LblDescriptionError
        {
            get { return _lblDescriptionError; }
            set { SetProperty(ref _lblDescriptionError, value); }
        }

        private string _lblNameError = string.Empty;
        public string LblNameError
        {
            get { return _lblNameError; }
            set { SetProperty(ref _lblNameError, value); }
        }

        private string _lblDateTimeError;
        public string LblDateTimeError
        {
            get { return _lblDateTimeError; }
            set { SetProperty(ref _lblDateTimeError, value); }
        }

        private bool Validate()
        {
            if (NameValidation() && DescriptionValidation() && DateTimeValidation())
                return true;
            return false;
        }
        private bool DateTimeValidation()
        {
            bool isValid = true;
            if (dateTime == null)
            {
                isValid = false;
                LblDateTimeError = Messages.RequiredField;
            }
            if(DateTime.Compare(dateTime,DateTime.Now)<=0)
            {
                isValid = false;
                LblDateTimeError = "Date and time of event must be set in the future.";
            }    
            if (isValid == true)
            {
                LblNameError = null;

            }
            return isValid;
        }
        private bool NameValidation()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrEmpty(Name))
            {
                LblNameError = Messages.RequiredField;
                isValid = false;
            }
            else if (Name.Length < 2)
            {
                LblNameError = Messages.Min2Characters;
                isValid = false;
            }

            if (isValid == true)
            {
                LblNameError = null;

            }
            return isValid;
        }
        private bool DescriptionValidation()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Description) || string.IsNullOrEmpty(Description))
            {
                LblDescriptionError = Messages.RequiredField;
                isValid = false;
            }
            else if (Description.Length < 5)
            {
                LblDescriptionError = Messages.Min5Characters;
                isValid = false;
            }

            if (isValid == true)
            {
                LblDescriptionError = null;

            }
            return isValid;
        }
    }
}
