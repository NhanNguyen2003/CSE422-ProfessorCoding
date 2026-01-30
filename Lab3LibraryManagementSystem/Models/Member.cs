using Lab3LibraryManagementSystem.Interfaces;
using Lab3LibraryManagementSystem.Models;

namespace Lab3LibraryManagementSystem.Models
{
    public class Member : IPrintable, IMemberActions
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Email}");
        }

        public void PrintDetails()
        {
            DisplayInfo();
        }

        public virtual void BorrowBook(Book book)
        {
            Console.WriteLine($"{Name} borrows {book.Title}");
        }

        public virtual void ReturnBook(Book book)
        {
            Console.WriteLine($"{Name} returns {book.Title}");
        }
    }
}
