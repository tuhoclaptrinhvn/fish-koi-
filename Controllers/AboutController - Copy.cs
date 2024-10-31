using Microsoft.AspNetCore.Mvc;

namespace Managerment_fish.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
