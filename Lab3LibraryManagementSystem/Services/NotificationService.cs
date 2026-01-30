namespace Lab3LibraryManagementSystem.Services
{
    public class NotificationService
    {
        public virtual void SendNotification(string message)
        {
            Console.WriteLine("Notification: " + message);
        }

        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"To {recipient}: {message}");
        }

        public void SendNotification(string message, List<string> recipients)
        {
            foreach (var r in recipients)
            {
                Console.WriteLine($"To {r}: {message}");
            }
        }

    }

    public class AdvancedNotificationService : NotificationService
    {
        public override void SendNotification(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

}
