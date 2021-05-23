using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.CustomValidationAttributes
{
    public class LettersOnly:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string str)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    return ValidationResult.Success;
                }

                if (str.Any(x => !char.IsLetter(x)))
                    return new ValidationResult(ErrorMessage);

                return ValidationResult.Success;
            }

            return ValidationResult.Success;
        }
        
    }
}
