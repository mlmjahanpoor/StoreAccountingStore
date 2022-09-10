using Microsoft.AspNetCore.Mvc;

namespace StoreAccounting.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
