using System.ComponentModel.DataAnnotations;

namespace ModelValidations.Validations
{
    public class MinimumAge : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                DateTime now = DateTime.Now;
                int yearDiff = now.Year - date.Year; 
                if (yearDiff >= 18)
                {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult("Must be over 18 years ago.");
                }
            }

            return new ValidationResult("{0} must not be null.");
        }
    }
}
