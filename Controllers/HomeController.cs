using Microsoft.AspNetCore.Mvc;
using Ch02Ex1FutureValue.Models;

namespace Ch02Ex1FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FV = 0;
        return View();
    }
        [HttpPost]
        public IActionResult Index(FutureValueModel Model)
        {
            ViewBag.FV = Model.CalculateFutureValue();
            return View(Model);
        }
        
    }
}
