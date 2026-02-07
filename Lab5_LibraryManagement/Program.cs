using Lab5_LibraryManagement.Patterns.Factory;
using Lab5_LibraryManagement.Patterns.Observer;
using Lab5_LibraryManagement.Patterns.Singleton;
using Lab5_LibraryManagement.Patterns.Strategy;

class Program
{
    static void Main(string[] args)
    {
        var db = DatabaseConnection.GetInstance();
        db.ExecuteQuery("SELECT * FROM Documents");

        var book = DocumentFactory.CreateDocument("book", "Design Patterns");
        book.DisplayInfo();

        var notifier = new LibraryNotifier();

        var user1 = new UserSubscriber("Alice");
        var user2 = new UserSubscriber("Bob");

        notifier.Subscribe(user1);
        notifier.Subscribe(user2);

        notifier.Notify("New book added: Design Patterns");

        var loan = new Loan(new BookFeeStrategy());
        Console.WriteLine("Loan fee for 5 days: " + loan.GetFee(5));
    }
}
