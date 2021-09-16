using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class EventAttendanceViewModel:BaseViewModel
    {
        private readonly APIService _eventService = new APIService("Events/GetAttendances");
        public ObservableCollection<Model.Response.EventAttendance> AttendanceList { get; set; } = new ObservableCollection<Model.Response.EventAttendance>();
        public ICommand InitCommand { get; set; }
        public int EventId { get; set; }
        public EventAttendanceViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var list = await _eventService.GetById<IEnumerable<Model.Response.EventAttendance>>(EventId);
            AttendanceList.Clear();
            foreach (var member in list)
            {
                AttendanceList.Add(member);
            }
        }

    }
}
