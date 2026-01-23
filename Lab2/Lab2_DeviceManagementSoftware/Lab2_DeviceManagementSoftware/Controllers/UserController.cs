using Lab2_DeviceManagementSoftware.Models;

using Microsoft.AspNetCore.Mvc;

namespace Lab2_DeviceManagementSoftware.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Data.Users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.User user)
        {
            user.UserId = Data.Data.Users.Count + 1;
            Data.Data.Users.Add(user);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var user = Data.Data.Users.FirstOrDefault(u => u.UserId == id);
            Data.Data.Users.Remove(user);
            return RedirectToAction("Index");
        }
    }

}
