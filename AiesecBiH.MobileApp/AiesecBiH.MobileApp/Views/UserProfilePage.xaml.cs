using AiesecBiH.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiesecBiH.MobileApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AiesecBiH.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserProfilePage : ContentPage
    {
        public MemberDetailsViewModel model = null;
        public UserProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new MemberDetailsViewModel() { Member = APIService.LoggedUser };

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new UserProfileUpdatePage(), true);

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}