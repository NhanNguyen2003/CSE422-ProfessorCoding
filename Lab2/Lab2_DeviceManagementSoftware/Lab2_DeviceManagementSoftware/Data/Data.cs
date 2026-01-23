using Lab2_DeviceManagementSoftware.Models;

namespace Lab2_DeviceManagementSoftware.Data
{
    public class Data
    {
        public static List<DeviceCategory> Categories = new List<DeviceCategory>
        {
            new DeviceCategory { Id = 1, CategoryName = "Laptops" },
            new DeviceCategory { Id = 2, CategoryName = "Desktops" },
            new DeviceCategory { Id = 3, CategoryName = "Tablets" },
            new DeviceCategory { Id = 4, CategoryName = "Smartphones" }
        };

        public static List<Device> Devices = new List<Device>
        {
            new Device
            {
                Id = 1,
                DeviceName = "Dell XPS 13",
                DeviceCode = "DX13-001",
                DeviceCategoryId = 1,
                DeviceCategory = Categories.First(c => c.Id == 1),
                Status = DeviceStatus.InUse,
                DateOfEntry = new DateTime(2023, 1, 15)
            },
            new Device
            {
                Id = 2,
                DeviceName = "iPad Pro",
                DeviceCode = "IPD-PRO-002",
                DeviceCategoryId = 3,
                DeviceCategory = Categories.First(c => c.Id == 3),
                Status = DeviceStatus.UnderMaintenance,
                DateOfEntry = new DateTime(2023, 3, 22)
            },
            new Device
            {
                Id = 3,
                DeviceName = "Samsung Galaxy S21",
                DeviceCode = "SGS21-003",
                DeviceCategoryId = 4,
                DeviceCategory = Categories.First(c => c.Id == 4),
                Status = DeviceStatus.Broken,
                DateOfEntry = new DateTime(2022, 11, 5)
            }
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
            UserId = 1,
            FullName = "Nguyen Van A",
            Email = "a@gmail.com",
            PhoneNumber = "0901234567"
            }
        };
    }


}
