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
    public partial class MemberDetailsPage : ContentPage
    {
        public MemberDetailsViewModel model = null;
        public MemberDetailsPage(Model.Response.MemberLL member)
        {
            InitializeComponent();
            BindingContext = model = new MemberDetailsViewModel() { Member=member };
        }
    }
}