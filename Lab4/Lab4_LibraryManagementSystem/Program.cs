class Program
{
    static void Main()
    {
        IBookRepository bookRepo = new BookRepository();
        IReaderRepository readerRepo = new ReaderRepository();

        DataSeeder.Seed(bookRepo, readerRepo);

        ILendingService lendingService =
            new LendingService(bookRepo, readerRepo);

        IReportService reportService =
            new ReportService(readerRepo);

        Console.WriteLine("=== TEST 1: Borrow Books Successful ===");
        bool t1 = lendingService.LendBook("R1", "B1");
        Console.WriteLine("Result: " + t1);

        Console.WriteLine("\n=== TEST 2: Borrow more than 3 books ===");
        lendingService.LendBook("R1", "B2");
        lendingService.LendBook("R1", "B3");
        bool t2 = lendingService.LendBook("R1", "B4");
        Console.WriteLine("Result: " + t2);

        Console.WriteLine("\n=== TEST 3: Return Book ===");
        bool t3 = lendingService.ReturnBook("R1", "B1");
        Console.WriteLine("Return result: " + t3);

        Console.WriteLine("\n=== TEST 4: Finding Book ===");
        var books = bookRepo.SearchByCategory("IT");
        foreach (var b in books)
            Console.WriteLine(b.Title);

        Console.WriteLine("\n=== TEST 5: Report ===");
        reportService.GenerateReport();

        Console.ReadLine();
    }
}
