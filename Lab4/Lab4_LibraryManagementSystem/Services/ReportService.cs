using System;

public class ReportService : IReportService
{
    private readonly IReaderRepository readerRepo;

    public ReportService(IReaderRepository readerRepo)
    {
        this.readerRepo = readerRepo;
    }

    public void GenerateReport()
    {
        Console.WriteLine("===== LIBRARY REPORT =====");

        foreach (var reader in readerRepo.GetAllReaders())
        {
            Console.WriteLine("Reader: " + reader.Name);

            foreach (var book in reader.BorrowedBooks)
            {
                Console.WriteLine(" - " + book.Title);
            }

            Console.WriteLine();
        }
    }
}
