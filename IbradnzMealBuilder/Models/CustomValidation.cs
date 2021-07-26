using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class BeginWIthAlphabeth : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;

            if (string.IsNullOrEmpty(strValue))
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            if (strValue.Length < 1)
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            if (!char.IsLetter(strValue[0]))
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            return ValidationResult.Success;
        }
    }

    public class BeginWIthAlphaNumeric : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;

            if (string.IsNullOrEmpty(strValue))
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            if (strValue.Length < 1)
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            if (!char.IsLetterOrDigit(strValue[0]))
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));

            return ValidationResult.Success;
        }
    }

}
