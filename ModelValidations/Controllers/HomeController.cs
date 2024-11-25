using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelValidations.Models;

namespace ModelValidations.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                string errors = string.Join("\n",
                    ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(err => err.ErrorMessage));

                return BadRequest(errors);
            } else
            {
                return Ok(person);
            }            
        }

        [Route("test-user")]
        public Person Details()
        {
            Person person = new Person()
            {
                Name = "Max Schessler",
                Email = "email@email.com",
                Password = "password",
                ConfirmPassword = "password",
                Phone = "123-456-7890",
                Price = 150.00,
                DOB = new DateTime(2005, 12, 21),
            };

            return person;
        }
    }
}


public record BadRequestModel(ModelStateDictionary ModelState, int NumberOfErrors);