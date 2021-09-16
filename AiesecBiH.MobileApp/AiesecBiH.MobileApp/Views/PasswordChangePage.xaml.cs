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
    public partial class PasswordChangePage : ContentPage
    {
        UserProfileViewModel model = null;
        public PasswordChangePage()
        {
            InitializeComponent();
            BindingContext = model = new UserProfileViewModel();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }
    }
}