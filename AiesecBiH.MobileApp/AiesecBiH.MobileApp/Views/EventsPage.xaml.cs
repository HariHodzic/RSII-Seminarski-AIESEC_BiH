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
    public partial class EventsPage : ContentPage
    {
        private EventsViewModel model = null;

        public EventsPage()
        {
            InitializeComponent();
            BindingContext = model = new EventsViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void btnNewEvent_Clicked(object sender, EventArgs e)
        {
            if (APIService.LoggedUser.RoleId == 4)
            {
                await Application.Current.MainPage.DisplayAlert("Event", "You are not authorized to create event.", "OK");

            }
            else if (APIService.LoggedUser.RoleId == 1)
            {
                await Application.Current.MainPage.DisplayAlert("Event", "Admin is not allowed to create event.", "OK");

            }
            else
            {
                await Navigation.PushAsync(new NewEventPage());

            }

        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var eventDetails = e.SelectedItem as Model.Response.Event;

            await Navigation.PushAsync(new EventDetailsPage(eventDetails));
        }
    }
}