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
    public partial class EventDetailsPage : ContentPage
    {
        private EventsViewModel model = null;

        public EventDetailsPage(Model.Response.Event result)
        {
            InitializeComponent();
            BindingContext = model = new EventsViewModel() { EventDetails = result };
        }
    }
}