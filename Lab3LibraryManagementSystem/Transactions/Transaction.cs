using Lab3LibraryManagementSystem.Models;

namespace Lab3LibraryManagementSystem.Transactions
{
    public abstract class Transaction
    {
        public string TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Member Member { get; set; }

        public abstract void Execute();
    }
}
