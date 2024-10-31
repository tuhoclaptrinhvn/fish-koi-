using Microsoft.AspNetCore.Mvc;

namespace Managerment_fish.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
