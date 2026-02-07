using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Models
{
    public interface IDocument
    {
        string Title { get; }
        void DisplayInfo();
    }
}
