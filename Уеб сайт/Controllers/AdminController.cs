using Microsoft.AspNetCore.Mvc;

namespace HouseManager.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
