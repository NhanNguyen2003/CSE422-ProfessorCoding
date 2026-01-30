using Lab3LibraryManagementSystem;
using Lab3LibraryManagementSystem.Models;
using Lab3LibraryManagementSystem.Services;
using Lab3LibraryManagementSystem.Transactions;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=======================================");
        Console.WriteLine("   LIBRARY MANAGEMENT SYSTEM - DEMO");
        Console.WriteLine("=======================================\n");

        // ==================================================
        // EXERCISE 1 – ENCAPSULATION
        // ==================================================
        Console.WriteLine("EXERCISE 1: Encapsulation - Book\n");

        Book book = new Book
        {
            ISBN = "001",
            Title = "CodingPractice",
            Author = "EIU",
            Year = 2026,
            CopiesAvailable = 2
        };

        book.DisplayInfo();
        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 2 – INHERITANCE
        // ==================================================
        Console.WriteLine("EXERCISE 2: Inheritance - Member\n");

        Member member = new Member
        {
            MemberID = "M01",
            Name = "Nhan1",
            Email = "nhan1@gmail.com"
        };

        PremiumMember premium = new PremiumMember
        {
            MemberID = "PM01",
            Name = "Nhan2",
            Email = "nhan2@gmail.com",
            MembershipExpiry = DateTime.Now.AddYears(1),
            MaxBooksAllowed = 5
        };

        member.DisplayInfo();
        Console.WriteLine();
        premium.DisplayInfo();

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 3 – ABSTRACTION
        // ==================================================
        Console.WriteLine("EXERCISE 3: Abstraction - Transaction\n");

        BorrowTransaction borrow = new BorrowTransaction
        {
            TransactionID = "T01",
            TransactionDate = DateTime.Now,
            Member = member,
            BookBorrowed = book
        };

        borrow.Execute();

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 4 – POLYMORPHISM
        // ==================================================
        Console.WriteLine("EXERCISE 4: Polymorphism\n");

        List<Transaction> transactions = new List<Transaction>
    {
        new BorrowTransaction
        {
            Member = member,
            BookBorrowed = book
        },
        new ReturnTransaction
        {
            Member = member,
            BookReturned = book
        }
    };

        foreach (Transaction t in transactions)
        {
            t.Execute();
        }

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 5 – INTERFACES
        // ==================================================
        Console.WriteLine("EXERCISE 5: Interfaces\n");

        member.BorrowBook(book);
        member.ReturnBook(book);
        member.PrintDetails();

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 6 – CONSTRUCTORS
        // ==================================================
        Console.WriteLine("EXERCISE 6: Constructors - Library\n");

        Library lib1 = new Library();
        lib1.DisplayLibraryInfo();

        Library lib2 = new Library("EIU Library", new List<Book> { book });
        lib2.DisplayLibraryInfo();

        Library lib3 = new Library(lib2);
        lib3.DisplayLibraryInfo();

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 7 – OVERLOADING & OVERRIDING
        // ==================================================
        Console.WriteLine("EXERCISE 7: Overloading & Overriding\n");

        NotificationService notify = new NotificationService();
        notify.SendNotification("Hello notification");

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 8 – ACCESS MODIFIERS
        // ==================================================
        Console.WriteLine("EXERCISE 8: Library Card\n");

        LibraryCard card = new LibraryCard("CARD001", member);

        Console.WriteLine("Card Number: " + card.CardNumber);
        Console.WriteLine("Owner: " + card.Owner.Name);
        Console.WriteLine("Issue Date: " + card.IssueDate);

        card.RenewCard();
        Console.WriteLine("Renewed Date: " + card.IssueDate);

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 9 – CLASS vs RECORD (GIẢI THÍCH BẰNG OUTPUT)
        // ==================================================
        Console.WriteLine("EXERCISE 9: Class vs Record\n");

        Console.WriteLine("Class compares by reference");
        Console.WriteLine("Record compares by value and supports 'with'");

        Console.WriteLine("---------------------------------------\n");

        // ==================================================
        // EXERCISE 10 – DELEGATES & EVENTS
        // ==================================================
        Console.WriteLine("EXERCISE 10: Delegates & Events\n");

        Library libraryEvent = new Library();

        libraryEvent.OnBookBorrowed += (b, m) =>
        {
            Console.WriteLine($"[EVENT] {m.Name} borrowed {b.Title}");
        };

        libraryEvent.BorrowBook(book, member);

        Console.WriteLine("\n=======================================");
        Console.WriteLine("         END OF DEMO PROGRAM");
        Console.WriteLine("=======================================");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}
