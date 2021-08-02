using AiesecBiH.MobileApp.ViewModels;
using AiesecBiH.MobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TasksPage), typeof(TasksPage));
            Routing.RegisterRoute(nameof(MemberDetailsPage), typeof(MemberDetailsPage));
            Routing.RegisterRoute(nameof(UserProfilePage), typeof(UserProfilePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
