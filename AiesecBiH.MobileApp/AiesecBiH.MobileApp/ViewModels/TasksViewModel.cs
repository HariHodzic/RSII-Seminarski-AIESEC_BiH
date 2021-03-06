using AiesecBiH.MobileApp.Models;
using AiesecBiH.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class TasksViewModel:BaseViewModel
    {
        private readonly APIService _tasksService = new APIService("Tasks");
        public ObservableCollection<Model.Response.TaskDetails> TasksList { get; set; } = new ObservableCollection<Model.Response.TaskDetails>();
        public ICommand InitCommand { get; set; }
        public ObservableCollection<SearchOptions> SearchOptionsList { get; set; } = new ObservableCollection<SearchOptions>();


        public TasksViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SearchOptionsList.Add(SearchOptions.TeamActive);
            SearchOptionsList.Add(SearchOptions.AllTeam);
            SearchOptionsList.Add(SearchOptions.All);
            SearchOptionsList.Add(SearchOptions.AllActive);
        }


        private SearchOptions _searchOption = (SearchOptions)1;
        public SearchOptions SelectedSearchOption
        {
            get { return _searchOption; }
            set { 
                SetProperty(ref _searchOption, value);
                InitCommand.Execute(null);
            }
        }


        public async Task Init()
        {
            try
            {
                Model.Search.Task req;
                if(SelectedSearchOption== SearchOptions.TeamActive)
                {
                    req = new Model.Search.Task
                    {
                        Executed = false,
                        FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                        LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId
                    };
                    if (APIService.LoggedUser.FunctionalFieldId == 1)
                    {
                        req.FunctionalFieldId = 0;
                    }
                }
                else if (SelectedSearchOption == SearchOptions.AllActive)
                {
                    req = new Model.Search.Task
                    {
                        Executed = false
                    };
                }
                else if(SelectedSearchOption==SearchOptions.AllTeam)
                {
                    req = new Model.Search.Task
                    {
                        FunctionalFieldId = APIService.LoggedUser.FunctionalFieldId,
                        LocalCommitteeId = APIService.LoggedUser.LocalCommitteeId
                    };
                    if (APIService.LoggedUser.FunctionalFieldId == 1)
                    {
                        req.FunctionalFieldId = 0;
                    }
                }
                else
                {
                    req = null;
                }
                var list = await _tasksService.Get<IEnumerable<Model.Response.TaskDetails>>(req);
                TasksList.Clear();
                foreach (var task in list)
                {
                    TasksList.Add(task);
                }

            }catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Task", "There was an error.", "OK");
            }
        }
    }
}
