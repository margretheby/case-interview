using System;
namespace BookConsole.Models
{
    // Defining a class named "Book" to represent book information
    public class Book
    {
        // Defining properties for storing the book information
        public string title { get; set; }
        public List<string> authors { get; set; }
        public int pageCount { get; set; }
        public string publishedDate { get; set; }
        public List<IndustryIdentifier> industryIdentifiers { get; set; }
    }
} 

