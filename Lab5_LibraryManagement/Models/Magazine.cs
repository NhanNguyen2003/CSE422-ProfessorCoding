using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Models
{
    public class Magazine : IDocument
    {
        public string Title { get; private set; }

        public Magazine(string title)
        {
            Title = title;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title}");
        }
    }
}
