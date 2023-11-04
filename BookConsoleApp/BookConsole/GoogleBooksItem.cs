using BookConsole;

namespace BookConsole
{
    // A class to represent book information from the API
    public class GoogleBooksItem
    {
        // property named "volumeInfo" to store information about a book, using the Book class
        public Models.Book volumeInfo { get; set; }
    }
}

