using Microsoft.AspNetCore.Mvc;
using PhoneCatalog.Models;
using PhoneCatalog.Repository;

namespace PhoneCatalog.Web.Controllers;
public class PhoneController: Controller
{
    private readonly PersonRepository _personRepository;
    public PhoneController (PersonRepository personRepository)
    {
        _personRepository = personRepository;
    }



    [HttpGet("mainpage")]
    public IActionResult HomePage()
    {
        return View();
    }
}