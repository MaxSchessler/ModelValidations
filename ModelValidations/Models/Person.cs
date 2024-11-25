using System.ComponentModel.DataAnnotations;
using ModelValidations.Validations;

namespace ModelValidations.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} can't be empty or null.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} must have 6 - 100 characters.")]
        public string? Name { get; set; }
        [EmailAddress(ErrorMessage = "{0} property should be valid. ")]
        public string? Email { get; set; }
        public string? Phone {  get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword  { get; set; }
        public double? Price { get; set; }

        [MinimumAge(ErrorMessage = "DOB must be 18 years ago.")]
        public DateTime? DOB { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}, Password {Password}, " +
                $"ConfirmPassword: {ConfirmPassword}, Price: {Price}.";
        }
    }
}
