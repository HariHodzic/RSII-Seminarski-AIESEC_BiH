using System;
using System.Collections.Generic;
using System.Text;

namespace AiesecBiH.MobileApp
{
    public class Messages
    {
        public static string Unauthorized { get; set; } = "Not authorized!";

        public static string Forrbiden { get; set; } = "Forrbidden";

        public static string IntServerErr { get; set; } = "Internal server error";

        public static string BadRqst { get; set; } = "Bad request";
        public static string RequiredField { get; set; } = "This field is required";
        public static string Min5Characters { get; set; } = "Minimum 5 characters";
        public static string Min2Characters { get; set; } = "Minimum 2 characters";
        public static string PasswordConfirmationError { get; set; } = "Different confirmation password";
        public static string FalsePasswordError { get; set; } = "Wrong password";
        public static string PasswordLengthError { get; set; } = "Password must be between 8 and 50 characters long";
        public static string PasswordNumbersError { get; set; } = "Password must contain numbers";

        public static string PhoneNumberFormatError { get; set; } = "Phone number must be in this format e.g. 000111222";
        public static string EmailFormatError { get; set; } = "Must be in this format 'text@mail.com'";

    }
}
