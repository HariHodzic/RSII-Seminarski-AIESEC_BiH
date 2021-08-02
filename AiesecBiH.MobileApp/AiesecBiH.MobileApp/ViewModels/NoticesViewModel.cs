using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class NoticesViewModel
    {
        private readonly APIService _tasksService = new APIService("Notices");
        public ObservableCollection<Model.Response.Notice> NoticesList { get; set; } = new ObservableCollection<Model.Response.Notice>();
        public ICommand InitCommand { get; set; }
        public NoticesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await _tasksService.Get<IEnumerable<Model.Response.Notice>>(null);
            NoticesList.Clear();
            foreach (var notice in list)
            {
                NoticesList.Add(notice);
            }
        }
    }
}
