using Microsoft.AspNetCore.Mvc;

namespace Managerment_fish.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
