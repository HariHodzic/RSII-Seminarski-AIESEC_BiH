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
    public partial class NoticesPage : ContentPage
    {
        private NoticesViewModel model = null;
        public NoticesPage()
        {
            InitializeComponent();
            BindingContext = model = new NoticesViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void btnNewNotice_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewNoticePage());

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item =(Model.Response.Notice) e.SelectedItem;
            await Navigation.PushAsync(new NoticeDetailsPage(item));
        }
    }
}