public interface ILendingService
{
    bool LendBook(string readerId, string bookId);
    bool ReturnBook(string readerId, string bookId);
}
