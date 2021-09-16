using AiesecBiH.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels.Requests
{
    public class NewNoticeViewModel:BaseViewModel
    {
        private readonly APIService _noticesService = new APIService("Notices");
        public ICommand SaveCommand { get; set; }

        public NewNoticeViewModel()
        {
            SaveCommand = new Command(async () => await SaveNoticeAsync());
        }

        public async Task SaveNoticeAsync()
        {
            if (!Validate())
            {
                return;
            }

            Model.Insert.Notice request = new Model.Insert.Notice
            {
                Title = NoticeTitle,
                Body = Body,
                CreatedDate = DateTime.Now,
                MemberId=APIService.LoggedUser.Id
            };
            var result = await _noticesService.Insert<Model.Insert.Notice>(request);
            if (result != default(Model.Insert.Notice) && result != null)
            {

                await Application.Current.MainPage.DisplayAlert("Info", "Sucessfully created new notice", "OK");
                Application.Current.MainPage = new NoticesPage();

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Error", "OK");
            }

        }
        private string _title=string.Empty;
        public string NoticeTitle
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _body = string.Empty;
        public string Body
        {
            get { return _body; }
            set { SetProperty(ref _body, value); }
        }
        private string _lblTitleError = string.Empty;
        public string LblTitleError
        {
            get { return _lblTitleError; }
            set { SetProperty(ref _lblTitleError, value); }
        }

        private string _lblBodyError = string.Empty;
        public string LblBodyError
        {
            get { return _lblBodyError; }
            set { SetProperty(ref _lblBodyError, value); }
        }


        private bool Validate()
        {
            if (TitleValidation() && BodyValidation())
                return true;
            return false;
        }

        private bool TitleValidation()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(NoticeTitle) || string.IsNullOrEmpty(NoticeTitle))
            {
                LblTitleError = Messages.RequiredField;
                isValid = false;
            }
            else if (NoticeTitle.Length < 2)
            {
                LblTitleError = Messages.Min2Characters;
                isValid = false;
            }

            if (isValid == true)
            {
                LblTitleError = null;

            }
            return isValid;
        }
        private bool BodyValidation()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Body) || string.IsNullOrEmpty(Body))
            {
                LblBodyError = Messages.RequiredField;
                isValid = false;
            }
            else if (Body.Length < 5)
            {
                LblBodyError = Messages.Min5Characters;
                isValid = false;
            }

            if (isValid == true)
            {
                LblBodyError = null;

            }
            return isValid;
        }
    }
}
