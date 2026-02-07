using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Models
{
    public class Newspaper : IDocument
    {
        public string Title { get; private set; }

        public Newspaper(string title)
        {
            Title = title;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Newspaper: {Title}");
        }
    }
}
