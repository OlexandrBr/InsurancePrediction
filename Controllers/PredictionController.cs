using Microsoft.AspNetCore.Mvc;

namespace InsurancePrediction.Controllers;

public class PredictionController : Controller
{
    public IActionResult Index()
    {
        return View(new InsuranceModel.ModelInput { Age = 30, Bmi = 25 });
    }

    [HttpPost]
    public IActionResult Index(InsuranceModel.ModelInput input)
    {
        var result = InsuranceModel.Predict(input);
        ViewBag.Result = result.Score;
        return View(input);
    }
}
