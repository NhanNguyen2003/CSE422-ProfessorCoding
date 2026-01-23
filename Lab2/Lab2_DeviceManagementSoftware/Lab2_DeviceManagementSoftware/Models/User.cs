using System.ComponentModel.DataAnnotations;

namespace Lab2_DeviceManagementSoftware.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
