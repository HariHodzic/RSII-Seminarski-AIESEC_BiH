using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AiesecBiH.MobileApp.Views;
using Flurl.Http;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        private readonly APIService _memberService = new APIService("Members");
        private Model.Update.Member _memberUpdateRequest;
        public Model.Update.Member MemberUpdateRequest
        {
            get { return _memberUpdateRequest; }
            set { SetProperty(ref _memberUpdateRequest, value); }
        }

        public ICommand UpdateMyProfile { get; set; }

        public UserProfileViewModel()
        {
            UpdateMyProfile = new Command(async () => await UpdateMyProfil());
            Init();
            
        }

        private async Task UpdateMyProfil()
        {
            try
            {
                var entity = await _memberService.Update<Model.Response.MemberLL>(MemberUpdateRequest.Id, MemberUpdateRequest);
                if (entity != null)
                {
                    APIService.LoggedUser = await _memberService.Get<Model.Response.MemberLL>(null, "MyProfile");
                    await Application.Current.MainPage.DisplayAlert("Profile", "Profile changes saved successfully.", "OK");
                }

            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Profile", ex.InnerException.Message , "OK");

            }
        }
        public void Init()
        {
            if (MemberUpdateRequest == null)
            {
                MemberUpdateRequest = new Model.Update.Member()
                {
                    Id=APIService.LoggedUser.Id,
                    FirstName = APIService.LoggedUser.FirstName,
                    LastName = APIService.LoggedUser.LastName,
                    Address = APIService.LoggedUser.Address,
                    BirthDate = APIService.LoggedUser.BirthDate,
                    PhoneNumber = APIService.LoggedUser.PhoneNumber,
                    Gender = APIService.LoggedUser.Gender,
                    LocalCommitteeId=APIService.LoggedUser.LocalCommitteeId,
                    FunctionalFieldId=APIService.LoggedUser.FunctionalFieldId,
                    Active=APIService.LoggedUser.Active,
                    RoleId=APIService.LoggedUser.RoleId,
                    EmailAddress=APIService.LoggedUser.EmailAddress,
                    Username=APIService.LoggedUser.Username
                };
                
            }
        }
    }
}
