using AiesecBiH.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}