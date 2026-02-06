using System.Collections.Generic;
using System.Linq;

public class BookRepository : IBookRepository
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book FindById(string id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public List<Book> SearchByTitle(string title)
    {
        return books
            .Where(b => b.Title.ToLower().Contains(title.ToLower()))
            .ToList();
    }

    public List<Book> SearchByCategory(string category)
    {
        return books
            .Where(b => b.Category.ToLower() == category.ToLower())
            .ToList();
    }
}
