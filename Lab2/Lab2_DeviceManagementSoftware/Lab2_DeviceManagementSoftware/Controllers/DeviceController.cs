using Lab2_DeviceManagementSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_DeviceManagementSoftware.Controllers
{
    public class DeviceController : Controller
    {
        public IActionResult Index(string Search)
        {
            var devices = Data.Data.Devices;

            if (!string.IsNullOrEmpty(Search))
            {
                devices = devices.Where(d => d.DeviceName.Contains(Search) || d.DeviceCode.Contains(Search)).ToList();
            }

            return View(devices);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = Data.Data.Categories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Device device)
        {
            device.Id = Data.Data.Devices.Max(d => d.Id) + 1;
            Data.Data.Devices.Add(device);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var device = Data.Data.Devices.FirstOrDefault(d => d.Id == id);
            Data.Data.Devices.Remove(device);
            return RedirectToAction("Index");
        }

    }
}
