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
    public partial class UserProfileUpdatePage : ContentPage
    {
        private UserProfileViewModel model { get; set; }

        public UserProfileUpdatePage()
        {
            InitializeComponent();
            BindingContext = model = new UserProfileViewModel();

        }


    }
}