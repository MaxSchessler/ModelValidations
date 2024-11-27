using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidations.Models;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ModelValidations.Validations
{
    public class USPhoneNumber : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string phoneNumber && !string.IsNullOrEmpty(phoneNumber))
            {
               var regex = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                if (regex.IsMatch(phoneNumber))
                {
                    // Remove special characters from phone number
                    phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");
                    // set Phone property this attribute is over to formated phone number.
                    var phoneProperty = validationContext.ObjectType.GetProperty("Phone");
                    phoneProperty.SetValue(validationContext.ObjectInstance, phoneNumber, null);
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Invalid US phone number format.");
        }
    }
}
