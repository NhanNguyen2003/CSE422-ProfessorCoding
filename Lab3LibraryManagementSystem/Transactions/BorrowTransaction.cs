using Lab3LibraryManagementSystem.Models;

namespace Lab3LibraryManagementSystem.Transactions
{
    public class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }

        public override void Execute()
        {
            if (BookBorrowed.CopiesAvailable > 0)
            {
                BookBorrowed.CopiesAvailable--;
                Console.WriteLine($"{Member.Name} borrowed {BookBorrowed.Title}");
            }
            else
            {
                Console.WriteLine("No copies available.");
            }
        }
    }
}
