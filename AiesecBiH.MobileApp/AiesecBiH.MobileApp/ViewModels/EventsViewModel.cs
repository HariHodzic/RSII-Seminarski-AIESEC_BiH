using AiesecBiH.MobileApp.Models;
using AiesecBiH.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        private readonly APIService _eventService = new APIService("Events");
        public ObservableCollection<Model.Response.Event> EventsList { get; set; } = new ObservableCollection<Model.Response.Event>();
        public ObservableCollection<SearchOptions> SearchOptionsList { get; set; } = new ObservableCollection<SearchOptions>();

        public Model.Response.Event EventDetails { get; set; }
        public ICommand InitCommand { get; set; }
        public ICommand AttendCommand { get; set; }
        public ICommand GetAttendanceCommand { get; set; }


        public EventsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            AttendCommand = new Command(async () => await AttendOnEvent());
            GetAttendanceCommand= new Command(async () => await GetAttendance());
            SearchOptionsList.Add(SearchOptions.TeamActive);
            SearchOptionsList.Add(SearchOptions.AllTeam);
            SearchOptionsList.Add(SearchOptions.All);
            SearchOptionsList.Add(SearchOptions.AllActive);

        }

        private SearchOptions _searchOption = (SearchOptions)1;
        public SearchOptions SelectedSearchOption
        {
            get { return _searchOption; }
            set
            {
                SetProperty(ref _searchOption, value);
                InitCommand.Execute(null);
            }
        }

        public async Task Init()
        {
            Model.Search.Event request;
            if (SelectedSearchOption == SearchOptions.TeamActive)
            {
                request = new Model.Search.Event
                {
                    InPast = false,
                    FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                    LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId
                };
                if (APIService.LoggedUser.FunctionalFieldId == 1)
                {
                    request.FunctionalFieldId = 0;
                }
            }
            else if (SelectedSearchOption == SearchOptions.AllActive)
            {
                request = new Model.Search.Event
                {
                    InPast = false
                };
            }
            else if(SelectedSearchOption == SearchOptions.AllTeam)
            {
                request = new Model.Search.Event
                {
                    FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                    LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId
                };
                if (APIService.LoggedUser.FunctionalFieldId == 1)
                {
                    request.FunctionalFieldId = 0;
                }
            }
            else
            {
                request = null;
            }
            try
            {
                var list = await _eventService.Get<IEnumerable<Model.Response.Event>>(request);
                EventsList.Clear();
                foreach (var item in list)
                {
                    EventsList.Add(item);
                }
            }
            catch(Exception ex){
                await Application.Current.MainPage.DisplayAlert("Event", "There was an error.", "OK");
            }
            
        }

        public async Task GetAttendance()
        {
            await Shell.Current.Navigation.PushAsync(new EventAttendancePage(EventDetails.Id), true);

        }

        private async Task AttendOnEvent()
        {
            try
            {
                if(DateTime.Compare(EventDetails.DateTime,DateTime.Now)<0)
                {
                    await Application.Current.MainPage.DisplayAlert("Event", "Event attendance cannot be created after the event.", "OK");
                }
                else
                {
                    var result = await _eventService.PostMethod<Model.Response.EventAttendance>(EventDetails.Id, APIService.LoggedUser.Id, "Attend");
                    await Application.Current.MainPage.DisplayAlert("Event", "Event attendance created successfully.", "OK");
                    await Application.Current.MainPage.Navigation.PopAsync();

                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Event", "Event attendance already created!", "OK");
            }

        }

    }
}
