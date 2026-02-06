public class LendingService : ILendingService
{
    private readonly IBookRepository bookRepo;
    private readonly IReaderRepository readerRepo;

    public LendingService(IBookRepository bookRepo, IReaderRepository readerRepo)
    {
        this.bookRepo = bookRepo;
        this.readerRepo = readerRepo;
    }

    public bool LendBook(string readerId, string bookId)
    {
        var reader = readerRepo.FindById(readerId);
        var book = bookRepo.FindById(bookId);

        if (reader == null || book == null)
            return false;

        if (!reader.CanBorrow())
            return false;

        if (book.Quantity <= 0)
            return false;

        reader.BorrowBook(book);
        book.DecreaseQty();

        return true;
    }

    public bool ReturnBook(string readerId, string bookId)
    {
        var reader = readerRepo.FindById(readerId);
        var book = bookRepo.FindById(bookId);

        if (reader == null || book == null)
            return false;

        reader.ReturnBook(book);
        book.IncreaseQty();

        return true;
    }
}
