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
            if (ModelState.IsValid == false) 
                return BadRequest(new BadRequestModel(ModelState, ModelState.ErrorCount));
            return Content($"{person}");
        }
    }
}


public record BadRequestModel(ModelStateDictionary ModelState, int NumberOfErrors);