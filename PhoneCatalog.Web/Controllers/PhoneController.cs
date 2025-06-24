using Microsoft.AspNetCore.Mvc;
using PhoneCatalog.Models;
using PhoneCatalog.Repository;

namespace PhoneCatalog.Web.Controllers;
public class PhoneController: Controller
{
    private readonly Repositories _repository;
    public PhoneController(Repositories repository)
    {
        _repository = repository;
    }



    [HttpGet("mainpage")]
    public IActionResult HomePage()
    {
        return View();
    }
}