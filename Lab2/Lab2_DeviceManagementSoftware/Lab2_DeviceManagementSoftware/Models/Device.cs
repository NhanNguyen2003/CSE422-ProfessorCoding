using System.ComponentModel.DataAnnotations;

namespace Lab2_DeviceManagementSoftware.Models
{
    public class Device
    {
       public int Id { get; set; }
       [Required]
       public string DeviceName { get; set; }
       [Required]
       public String DeviceCode { get; set; }
       [Required]
       public int DeviceCategoryId { get; set; }
       public DeviceCategory DeviceCategory { get; set; }
       public DeviceStatus Status { get; set; }
       [DataType(DataType.Date)]
       public DateTime DateOfEntry { get; set; }
    }
}
