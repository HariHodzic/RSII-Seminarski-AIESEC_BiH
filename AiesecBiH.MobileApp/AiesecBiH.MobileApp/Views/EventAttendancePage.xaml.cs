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
    public partial class EventAttendancePage : ContentPage
    {
        private EventAttendanceViewModel model = null;
        public EventAttendancePage(int id)
        {
            InitializeComponent();
            BindingContext = model = new EventAttendanceViewModel() { EventId = id };

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}