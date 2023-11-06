// Define the namespace where this class belongs.
namespace MyCatalog.Models
{
    // Define a class named BooksEntity to represent book information.
    public class BooksEntity
    {
        // Property to store the unique identifier of the book.
        public int ID { get; set; }

        // Property to store the title of the book.
        public string Title { get; set; }

        // Property to store the author of the book.
        public string Author { get; set; }

        // Property to store the International Standard Book Number (ISBN) of the book.
        public string ISBN { get; set; }
    }
}
