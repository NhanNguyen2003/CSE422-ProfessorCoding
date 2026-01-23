using Microsoft.AspNetCore.Mvc;

namespace Lab2_DeviceManagementSoftware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
