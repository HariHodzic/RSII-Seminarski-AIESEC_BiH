using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AiesecBiH.Model.CustomValidationAttributes
{
    public class FutureDate:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (DateTime.TryParse(value.ToString(), out DateTime date))
            {
                if (date.Date < DateTime.Now.Date)
                {
                    return new ValidationResult(string.IsNullOrWhiteSpace(ErrorMessage)? "Date must be in future": ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
        
    }
}
