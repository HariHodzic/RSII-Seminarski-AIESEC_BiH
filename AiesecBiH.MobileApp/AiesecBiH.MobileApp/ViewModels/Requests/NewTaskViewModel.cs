using AiesecBiH.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels.Requests
{
    public class NewTaskViewModel : BaseViewModel
    {
        private readonly APIService _tasksService = new APIService("Tasks");
        public ICommand SaveCommand { get; set; }
        public ObservableCollection<Priority> PriorityList { get; set; } = new ObservableCollection<Priority>();

        public NewTaskViewModel()
        {
            SaveCommand = new Command(async () => await SaveTaskAsync());
            PriorityList.Add(Priority.Low);
            PriorityList.Add(Priority.High);
            PriorityList.Add(Priority.Medium);
        }

        public async Task SaveTaskAsync()
        {
            if (!Validate())
            {
                return;
            }

            Model.Insert.Task request = new Model.Insert.Task
            {
                Name = Name,
                Deadline = Deadline,
                Description = Description,
                CreatedDate = DateTime.Now,
                FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId,
                MemberCreatorId = APIService.LoggedUser.Id,
                Priority = this.Priority,
                RoleId=APIService.LoggedUser.RoleId
            };
            var result = await _tasksService.Insert<Model.Insert.Notice>(request);
            if (result != default(Model.Insert.Notice) && result != null)
            {

                await Application.Current.MainPage.DisplayAlert("Info", "Sucessfully created new Task", "OK");
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

        public DateTime _deadline=DateTime.Now;
        public DateTime Deadline
        {
            get { return _deadline; }
            set { SetProperty(ref _deadline, value); }
        }

        private Priority _priority = (Priority)1;
        public Priority Priority
        {
            get { return _priority; }
            set { SetProperty(ref _priority, value); }
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

        private string _lblDeadlineError;
        public string LblDeadlineError
        {
            get { return _lblDeadlineError; }
            set { SetProperty(ref _lblDeadlineError, value); }
        }

        private bool Validate()
        {
            if (NameValidation() && DescriptionValidation())
                return true;
            return false;
        }
        private bool DeadlineValidation()
        {
            bool isValid = true;
            if (Deadline == null)
            {
                isValid = false;
                LblDeadlineError = Messages.RequiredField;
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
            else if (Name.Length < 5)
            {
                LblNameError = Messages.Min5Characters;
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
