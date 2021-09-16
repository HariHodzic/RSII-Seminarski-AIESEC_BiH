using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class TaskDetailsViewModel : BaseViewModel
    {
        private readonly APIService _taskService = new APIService("Tasks");
        public Model.Response.TaskDetails TaskDetails { get; set; }
        public ICommand ExecuteTaskCommand { get; set; }
        public TaskDetailsViewModel()
        {
            ExecuteTaskCommand = new Command(async () => await ExecuteTask());
        }
        private async Task ExecuteTask()
        {
            try
            {
                if (TaskDetails.Executed == true)
                {
                    if (TaskDetails.MemberCreatorId!=APIService.LoggedUser.Id && TaskDetails.MemberExecutorId != APIService.LoggedUser.Id)
                    {
                        await Application.Current.MainPage.DisplayAlert("Task", "You are not authorized to change the status of this task.", "OK");
                        return;
                    }
                }
                var result = await _taskService.PostMethod<Model.Response.TaskDetails>(TaskDetails.Id, APIService.LoggedUser.Id,"Execute");
                await Application.Current.MainPage.DisplayAlert("Task", "Task status changed successfully.", "OK");
                await Application.Current.MainPage.Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Task", ex.Message, "OK");
            }

        }
    }
}
