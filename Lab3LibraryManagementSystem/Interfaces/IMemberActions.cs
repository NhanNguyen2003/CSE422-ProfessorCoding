using Lab3LibraryManagementSystem.Models;

namespace Lab3LibraryManagementSystem.Interfaces
{
    public interface IMemberActions
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}
