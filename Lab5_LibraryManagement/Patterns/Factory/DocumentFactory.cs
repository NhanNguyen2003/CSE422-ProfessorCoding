using Lab5_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_LibraryManagement.Patterns.Factory
{
    public static class DocumentFactory
    {
        public static IDocument CreateDocument(string type, string title)
        {
            return type.ToLower() switch
            {
                "book" => new Book(title),
                "magazine" => new Magazine(title),
                "newspaper" => new Newspaper(title),
                _ => throw new ArgumentException("Invalid document type")
            };
        }
    }
}
