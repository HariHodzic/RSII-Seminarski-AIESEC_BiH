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
        public TasksViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await _tasksService.Get<IEnumerable<Model.Response.TaskDetails>>(null);
            TasksList.Clear();
            foreach (var task in list)
            {
                TasksList.Add(task);
            }
        }
    }
}
