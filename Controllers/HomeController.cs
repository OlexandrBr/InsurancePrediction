using Microsoft.AspNetCore.Mvc;

namespace InsurancePrediction.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
