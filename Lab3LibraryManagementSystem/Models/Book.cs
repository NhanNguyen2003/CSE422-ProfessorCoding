using Lab3LibraryManagementSystem.Interfaces;

namespace Lab3LibraryManagementSystem.Models
{
    
        public class Book : IPrintable
        {
            private int year;
            private int copiesAvailable;

            public string ISBN { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }

            public int Year
            {
                get => year;
                set
                {
                    if (value >= 0)
                        year = value;
                }
            }

            public int CopiesAvailable
            {
                get => copiesAvailable;
                set
                {
                    if (value >= 0)
                        copiesAvailable = value;
                }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"{Title} - {Author} ({Year})");
            }

            public void PrintDetails()
            {
                DisplayInfo();
            }
        
    }

}
