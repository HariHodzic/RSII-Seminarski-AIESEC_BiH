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
    public partial class MembersPage : ContentPage
    {
        private MembersViewModel model = null;
        public MembersPage()
        {
            InitializeComponent();
            BindingContext = model = new MembersViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var member = (Model.Response.MemberLL)e.SelectedItem;
            await Navigation.PushAsync(new MemberDetailsPage(member));
        }
    }
}