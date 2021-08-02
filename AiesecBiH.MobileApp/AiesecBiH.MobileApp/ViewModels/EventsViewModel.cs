using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class EventsViewModel:BaseViewModel
    {
        private readonly APIService _eventService = new APIService("Events");
        public ObservableCollection<Model.Response.Event> EventsList { get; set; } = new ObservableCollection<Model.Response.Event>();
        public ICommand InitCommand { get; set; }

        public EventsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await _eventService.Get<IEnumerable<Model.Response.Event>>(null);
            EventsList.Clear();
            foreach (var item in list)
            {
                EventsList.Add(item);
            }
        }

    }
}
