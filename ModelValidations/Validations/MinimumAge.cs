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
                if (date.Year - now.Year == 0)
                {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult("Must be over 18 years ago.")
                }
            }
        }
    }
}
