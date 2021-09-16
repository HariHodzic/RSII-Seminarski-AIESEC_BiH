using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using AiesecBiH.MobileApp.Views;
using Flurl.Http;
using System.Text.RegularExpressions;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        private readonly APIService _memberService = new APIService("Members");
        private Model.Update.Member _memberUpdateRequest;
        public Model.Response.Member member;
        public Model.Update.Member MemberUpdateRequest
        {
            get { return _memberUpdateRequest; }
            set { SetProperty(ref _memberUpdateRequest, value); }
        }

        public ICommand UpdateMyProfile { get; set; }
        public ICommand SavePasswordCommand { get; set; }

        public UserProfileViewModel()
        {
            UpdateMyProfile = new Command(async () => await UpdateMyProfil());
            SavePasswordCommand = new Command(async () => await ChangePassword());

            Init();

        }
        private async Task UpdateMyProfil()
        {
            if (!Validate())
            {
                return;
            }

            Model.Update.Member request = new Model.Update.Member
            {
                Id=member.Id,
                Address = this.Address,
                EmailAddress = this.EmailAddress,
                FirstName = this.FirstName,
                LastName = this.LastName,
                PhoneNumber = this.PhoneNumber,
                FunctionalFieldId =member.FunctionalFieldId,
                LocalCommitteeId=member.LocalCommitteeId,
                Username=member.Username,
                Active=member.Active,
                BirthDate=member.BirthDate,
                Gender=member.Gender,
                RoleId=member.RoleId
            };


            var result = await _memberService.Update<Model.Response.MemberLL>(member.Id, request);
            if (result != null || result != default(Model.Response.MemberLL))
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Succesfully updated your profile", "Ok");
                await Application.Current.MainPage.Navigation.PopAsync();

            }
        }
        public void Init()
        {
            member = APIService.LoggedUser;
            
            FirstName = member.FirstName;
            LastName = member.LastName;
            Address = member.Address;
            PhoneNumber = member.PhoneNumber;
            EmailAddress = member.EmailAddress;
        }
        
        
        //==========Fields
        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _LastName = string.Empty;
        public string LastName
        {
            get { return _LastName; }
            set { SetProperty(ref _LastName, value); }
        }

        private string _PhoneNumber = string.Empty;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetProperty(ref _PhoneNumber, value); }
        }
        private string _Address = string.Empty;
        public string Address
        {
            get { return _Address; }
            set { SetProperty(ref _Address, value); }
        }

        private string _EmailAddress = string.Empty;
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { SetProperty(ref _EmailAddress, value); }
        }
        //UserUpdate
        public async Task SpasiPromjenu()
        {
            if (!Validate())
            {
                return;
            }

            Model.Update.Member request = new Model.Update.Member
            {
                Address = this.Address,
                EmailAddress = this.EmailAddress,
                FirstName = this.FirstName,
                LastName = this.LastName,
                //Password = null,
                //PasswordConfirmation = null,
                PhoneNumber = this.PhoneNumber,
            };


            var result = await _memberService.Update<Model.Response.MemberLL>(member.Id, request);
            if (result != null || result != default(Model.Response.MemberLL))
            {
                APIService.Username = request.Username;
                await Application.Current.MainPage.DisplayAlert("Info", "Uspjesna izmjena", "Ok");

            }

        }
        //Password Change
        public async Task ChangePassword()
        {
            if (CurrentPasswordValidation())
            {

                if (PasswordValidation() && PasswordConfirmationValidation())
                {
                    if (member == null)
                    {
                        return;
                    }
                    Model.Update.ChangePasswordModel request = new Model.Update.ChangePasswordModel
                    {
                        NewPassword = Password,
                        PasswordConfirmation = PassConfirmation,
                        OldPassword = CurrentPassword
                    };
                    var result = await _memberService.PostMethod<Model.Response.Member>(member.Id, request,"ChangePassword");
                    if (result != null || result != default(Model.Response.Member))
                    {
                        await Application.Current.MainPage.DisplayAlert("Info", "Succesfully updated password", "Ok");
                        Application.Current.MainPage = new NavigationPage(new LoginPage());

                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "There was an error", "Cancel");

                    }
                }
            }
        }
        private string _CurrentPassword = string.Empty;
        public string CurrentPassword
        {
            get { return _CurrentPassword; }
            set { SetProperty(ref _CurrentPassword, value); }
        }
        //---------------------------------------------------
        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _passConfirmation = string.Empty;
        public string PassConfirmation
        {
            get { return _passConfirmation; }
            set { SetProperty(ref _passConfirmation, value); }
        }

        //==============Validation fields============
        private string _lblPasswordErr = string.Empty;
        public string LblPasswordErr
        {
            get { return _lblPasswordErr; }
            set { SetProperty(ref _lblPasswordErr, value); }
        }

        private string _lblCurrentPasswordErr = string.Empty;
        public string LblCurrentPasswordErr
        {
            get { return _lblCurrentPasswordErr; }
            set { SetProperty(ref _lblCurrentPasswordErr, value); }
        }

        private string _lblPassConfirmationErr = string.Empty;
        public string LblPassConfirmationErr
        {
            get { return _lblPassConfirmationErr; }
            set { SetProperty(ref _lblPassConfirmationErr, value); }
        }
        private string _lblFirstNameErr = string.Empty;
        public string LblFirstNameErr
        {
            get { return _lblFirstNameErr; }
            set { SetProperty(ref _lblFirstNameErr, value); }
        }

        private string _lblLastNameErr = string.Empty;
        public string LblLastNameErr
        {
            get { return _lblLastNameErr; }
            set { SetProperty(ref _lblLastNameErr, value); }
        }

        private string _lblPhoneNumberErr = string.Empty;
        public string LblPhoneNumberErr
        {
            get { return _lblPhoneNumberErr; }
            set { SetProperty(ref _lblPhoneNumberErr, value); }
        }

        private string _lblAddressErr = string.Empty;
        public string LblAddressErr
        {
            get { return _lblAddressErr; }
            set { SetProperty(ref _lblAddressErr, value); }
        }

        private string _lblEmailAddressErr = string.Empty;
        public string LblEmailAddressErr
        {
            get { return _lblEmailAddressErr; }
            set { SetProperty(ref _lblEmailAddressErr, value); }
        }
        //==============Validation methods=================
        private bool PasswordConfirmationValidation()
        {
            bool IsValid = true;
            if (string.IsNullOrWhiteSpace(PassConfirmation) || string.IsNullOrEmpty(PassConfirmation))
            {
                LblPassConfirmationErr = Messages.RequiredField;
                IsValid = false;
            }
            else if (PassConfirmation != Password)
            {
                LblPassConfirmationErr = Messages.PasswordConfirmationError;
                IsValid = false;
            }

            if (IsValid == true)
            {
                LblPassConfirmationErr = null;
            }
            return IsValid;
        }

        private bool CurrentPasswordValidation()
        {
            bool IsValid = true;
            if (string.IsNullOrEmpty(CurrentPassword))
            {
                LblCurrentPasswordErr = Messages.RequiredField;
                IsValid = false;
            }

            else if (CurrentPassword != APIService.Password)
            {
                LblCurrentPasswordErr = Messages.FalsePasswordError;
                IsValid = false;
            }
            if (IsValid == true)
            {
                LblCurrentPasswordErr = null;
            }
            return IsValid;
        }
        private bool PasswordValidation()
        {
            bool IsValid = true;
            Regex hasNumber = new Regex(@"[0-9]+");


            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrEmpty(Password))
            {
                LblPasswordErr = Messages.RequiredField;
                IsValid = false;
            }
            else if (Password.Length < 8 || Password.Length > 50)
            {
                LblPasswordErr = Messages.PasswordLengthError;
                IsValid = false;
            }
            else if (!hasNumber.IsMatch(Password))
            {
                LblPasswordErr = Messages.PasswordNumbersError;
                IsValid = false;
            }
            if (IsValid == true)
            {
                LblPasswordErr = null;
            }
            return IsValid;
        }

        private bool FirstNameValidation()
        {
            bool IsValidno = true;
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrEmpty(FirstName))
            {
                LblFirstNameErr = Messages.RequiredField;
                IsValidno = false;
            }
            else if (FirstName.Length < 2)
            {
                LblFirstNameErr = Messages.Min2Characters;
                IsValidno = false;
            }

            if (IsValidno == true)
            {
                LblFirstNameErr = null;

            }
            return IsValidno;
        }
        private bool LastNameValidation()
        {
            bool IsValidno = true;
            if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrEmpty(LastName))
            {
                LblLastNameErr = Messages.RequiredField;
                IsValidno = false;
            }
            else if (LastName.Length < 2)
            {
                LblLastNameErr = Messages.Min2Characters;
                IsValidno = false;
            }

            if (IsValidno == true)
            {
                LblLastNameErr = null;

            }
            return IsValidno;
        }

        private bool PhoneNumberValidation()
        {
            bool IsValid = true;
            Regex regex = new Regex(@"[0-9]{9}");
            Regex hasLetter = new Regex(@"[a-zA-Z]+");
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                LblPhoneNumberErr = Messages.RequiredField;
                IsValid = false;
            }
            else if (hasLetter.IsMatch(PhoneNumber))
            {
                LblPhoneNumberErr = Messages.PhoneNumberFormatError;
                IsValid = false;
            }
            else if (hasSymbols.IsMatch(PhoneNumber))
            {
                LblPhoneNumberErr = Messages.PhoneNumberFormatError;
                IsValid = false;
            }
            else if (!regex.IsMatch(PhoneNumber))
            {
                LblPhoneNumberErr = Messages.PhoneNumberFormatError;
                IsValid = false;
            }
            else if (PhoneNumber.Length > 9)
            {
                LblPhoneNumberErr = Messages.PhoneNumberFormatError;
                IsValid = false;
            }
            else
            {
                LblPhoneNumberErr = null;
            }
            return IsValid;
        }

        private bool AddressValidation()
        {
            bool IsValidno = true;
            if (string.IsNullOrWhiteSpace(Address))
            {
                LblAddressErr = Messages.RequiredField;
                IsValidno = false;
            }
            else
            {
                LblAddressErr = null;
            }

            return IsValidno;
        }
        
        private bool EmailAddressValidation()
        {
            bool IsValidno = true;
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                LblEmailAddressErr = Messages.RequiredField;
                IsValidno = false;
            }
            //else if (CheckMail(EmailAddress)) // mail nije ispravnog formata
            //{
            //    LblEmailAddressErr = Messages.EmailAddressFormatError;
            //    IsValidno = false;
            //}
            else
            {
                LblEmailAddressErr = null;
            }

            return IsValidno;
        }
        private bool Validate()
        {

            if (FirstNameValidation() && LastNameValidation() && PhoneNumberValidation() && AddressValidation()  && EmailAddressValidation())
                return true;
            return false;
        }
    }
}