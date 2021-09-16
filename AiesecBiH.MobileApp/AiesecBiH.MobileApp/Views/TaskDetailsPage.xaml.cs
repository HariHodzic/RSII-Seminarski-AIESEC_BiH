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
    public partial class TaskDetailsPage : ContentPage
    {
        private TaskDetailsViewModel model=null;
        public TaskDetailsPage(Model.Response.TaskDetails task)
        {
            InitializeComponent();
            BindingContext = model = new TaskDetailsViewModel() { TaskDetails = task };
        }
    }
}