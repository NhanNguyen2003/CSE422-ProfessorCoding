using Lab2_DeviceManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_DeviceManagementSoftware.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Data.Categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DeviceCategory deviceCategory)
        {
            deviceCategory.Id = Data.Data.Categories.Count + 1;
            Data.Data.Categories.Add(deviceCategory);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = Data.Data.Categories.FirstOrDefault(c => c.Id == id);
            Data.Data.Categories.Remove(category);
            return RedirectToAction("Index");
        }
    }
}
