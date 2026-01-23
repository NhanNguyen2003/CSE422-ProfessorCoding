using System.ComponentModel.DataAnnotations;

namespace Lab2_DeviceManagementSoftware.Models
{
    public class DeviceCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        public string CategoryName { get; set; }
    }
}
