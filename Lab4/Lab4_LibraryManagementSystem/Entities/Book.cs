using System;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }

    public Book(string id, string title, string author, string category, int quantity)
    {
        Id = id;
        Title = title;
        Author = author;
        Category = category;
        Quantity = quantity;
    }

    public void IncreaseQty()
    {
        Quantity++;
    }

    public void DecreaseQty()
    {
        if (Quantity > 0)
            Quantity--;
    }
}
