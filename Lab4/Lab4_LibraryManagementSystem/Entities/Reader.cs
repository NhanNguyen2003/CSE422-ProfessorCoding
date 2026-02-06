using System.Collections.Generic;

public class Reader
{
    public string Id { get; set; }
    public string Name { get; set; }

    public List<Book> BorrowedBooks { get; set; } = new List<Book>();

    public Reader(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public bool CanBorrow()
    {
        return BorrowedBooks.Count < 3;
    }

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
    }
}

