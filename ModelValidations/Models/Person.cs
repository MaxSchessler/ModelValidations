using System.ComponentModel.DataAnnotations;

namespace ModelValidations.Models
{
    public class Person
    {
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone {  get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword  { get; set; }
        public double? Price { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}, Password {Password}, " +
                $"ConfirmPassword: {ConfirmPassword}, Price: {Price}.";
        }
    }
}
