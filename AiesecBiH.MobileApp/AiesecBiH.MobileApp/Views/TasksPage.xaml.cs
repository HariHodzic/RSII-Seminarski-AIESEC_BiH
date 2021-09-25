using AiesecBiH.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AiesecBiH.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasksPage : ContentPage
    {
        private TasksViewModel model = null;
        public TasksPage()
        {
            InitializeComponent();
            BindingContext = model = new TasksViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void btnNewTask_Clicked(object sender, EventArgs e)
        {
            if (APIService.LoggedUser.RoleId == 1)
            {
                await Application.Current.MainPage.DisplayAlert("Event", "Admin is not allowed to create task.", "OK");

            }
            else
            {
                await Navigation.PushAsync(new NewTaskPage());
            }

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var task = e.SelectedItem as Model.Response.TaskDetails;

            await Navigation.PushAsync(new TaskDetailsPage(task));
        }
    }
}