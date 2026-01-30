using Lab3LibraryManagementSystem.Models;

namespace Lab3LibraryManagementSystem.Transactions
{
    public class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }

        public override void Execute()
        {
            BookReturned.CopiesAvailable++;
            Console.WriteLine($"{Member.Name} returned {BookReturned.Title}");
        }
    }
}
