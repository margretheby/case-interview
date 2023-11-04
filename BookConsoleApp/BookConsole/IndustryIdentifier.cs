
namespace BookConsole
{
    // A class to represent industry identifiers for books
    public class IndustryIdentifier
    {
        // property that stores the type of industry identifier (ex: ISBN_10)
        public string type { get; set; }
        // property that stores the value of the industry identifier (the ISBN number, ex: 9781483483078)
        public string identifier { get; set; }
    }
}