using Lab3LibraryManagementSystem.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab3LibraryManagementSystem
{
    public class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public event Action<Book, Member>? OnBookBorrowed;

        public Library()
        {
            LibraryName = "Default Library";
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public Library(string name, List<Book> books)
        {
            LibraryName = name;
            Books = books;
            Members = new List<Member>();
        }

        public Library(Library other)
        {
            LibraryName = other.LibraryName;
            Books = new List<Book>(other.Books);
            Members = new List<Member>(other.Members);
        }

        public void DisplayLibraryInfo()
        {
            Console.WriteLine("Library Name: " + LibraryName);
            Console.WriteLine("Total Books: " + Books.Count);
            Console.WriteLine("Total Members: " + Members.Count);
        }

        public void BorrowBook(Book book, Member member)
        {
            OnBookBorrowed?.Invoke(book, member);
        }
    }
}
