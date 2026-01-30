namespace Lab3LibraryManagementSystem.Models
{
    public class PremiumMember : Member
    {
        public DateTime MembershipExpiry { get; set; }
        public int MaxBooksAllowed { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Expiry: {MembershipExpiry}");
            Console.WriteLine($"Max Books: {MaxBooksAllowed}");
        }
    }
}
