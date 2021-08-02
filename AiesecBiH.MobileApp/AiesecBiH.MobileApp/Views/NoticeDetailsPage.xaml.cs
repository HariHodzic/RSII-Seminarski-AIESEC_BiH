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
    public partial class NoticeDetailsPage : ContentPage
    {
        private NoticeDetailsViewModel model = null;
        public NoticeDetailsPage(Model.Response.Notice item)
        {
            InitializeComponent();
            BindingContext = model = new NoticeDetailsViewModel() { Notice = item };
        }
    }
}