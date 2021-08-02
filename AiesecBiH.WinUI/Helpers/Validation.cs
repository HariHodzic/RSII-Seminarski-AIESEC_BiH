using AiesecBiH.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
    }
}
