using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Models
{
    public class Book : IDocument
    {
        public string Title { get; private set; }

        public Book(string title)
        {
            Title = title;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}");
        }
    }
}
