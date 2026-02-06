using System.Collections.Generic;

public interface IBookRepository
{
    Book FindById(string id);
    void AddBook(Book book);
    List<Book> SearchByTitle(string title);
    List<Book> SearchByCategory(string category);
}
