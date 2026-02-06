public static class DataSeeder
{
    public static void Seed(IBookRepository bookRepo, IReaderRepository readerRepo)
    {
        bookRepo.AddBook(new Book("B1", "Clean Code", "Uncle Bob", "IT", 5));
        bookRepo.AddBook(new Book("B2", "C# Basics", "Microsoft", "IT", 3));
        bookRepo.AddBook(new Book("B3", "Doraemon", "Fujiko", "Comic", 10));

        readerRepo.AddReader(new Reader("R1", "Nhan1"));
        readerRepo.AddReader(new Reader("R2", "Nhan2"));
    }
}
