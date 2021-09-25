using AiesecBiH.MobileApp.Views;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Members");
        public int UserId;
        private string _username = string.Empty;
        private string _password = string.Empty;
        public ICommand LoginCommand { get; }

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            try
            {
                //await _service.Get<dynamic>(null);
                APIService.LoggedUser = await _service.Get<Model.Response.MemberLL>(null,"MyProfile");
                UserId = APIService.LoggedUser.Id;
                //if (APIService.LoggedUser.RoleId == 1)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Error", "Mobile application is for users only!", "OK");

                //}
                Application.Current.MainPage = new AppShell();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response?.StatusCode == ((int)System.Net.HttpStatusCode.Unauthorized))
                {
                   await Application.Current.MainPage.DisplayAlert("Error", " Wrong username or password!", "OK");
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}
