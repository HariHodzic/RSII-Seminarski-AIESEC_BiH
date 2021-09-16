using AiesecBiH.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiesecBiH.WinUI.Helpers
{
    public static class Validation
    {
        public static bool BaseValidation(object data)
        {
            ValidationContext context = new ValidationContext(data, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(data, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage,"Invalid input", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool EmailValidation(string email)
        {
            try
            {
                var adress = new MailAddress(email);
                    return adress.Address == email;
                
            }
            catch
            {
                return false;
            }
        }
        public static bool IsPhoneNumberValid(string PhoneNumber)
        {
            bool IsValid = true;
            Regex regex = new Regex(@"[0-9]{9}");
            Regex hasLetter = new Regex(@"[a-zA-Z]+");
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                IsValid = false;
            }
            else if (hasLetter.IsMatch(PhoneNumber))
            {
                IsValid = false;
            }
            else if (hasSymbols.IsMatch(PhoneNumber))
            {
                IsValid = false;
            }
            else if (!regex.IsMatch(PhoneNumber))
            {
                IsValid = false;
            }
            else if (PhoneNumber.Length > 9)
            {
                IsValid = false;
            }
            
            return IsValid;
        }
    }
}
