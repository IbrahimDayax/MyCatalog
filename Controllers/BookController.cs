using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCatalog.Models;
using MyCatalog.Data;

namespace MyCatalog.Controllers
{
    // Define the BookController class, which is a controller in your application.
    public class BookController : Controller
    {
        // Create a private field _db of type ApplicationDbContext to interact with the database.
        private ApplicationDbContext _db;

        // Create a constructor that accepts an instance of ApplicationDbContext through dependency injection.
        public BookController(ApplicationDbContext db)
        {
            // Initialize the _db field with the provided database context.
            _db = db;
        }

        // Define an action method named "Index." This method handles requests to the path "/Book/Index".
        public IActionResult Index()
        {
            // Retrieve a list of books from the database and store them in the "books" variable.
            var books = _db.Books.ToList();

            // Return a view with the list of books, passing the "books" variable to the view.
            return View(books);
        }

        // Define an action method named "Add." This method handles requests to the path "/Book/Add".
        public IActionResult Add()
        {
            // Return a view for adding a new book.
            return View();
        }

        // Define a [HttpPost] action method named "AddBook" to handle form submissions for adding a new book.
        [HttpPost]
        public IActionResult AddBook(BooksEntity book)
        {
            // Add the book object received from the form to the database context's "Books" DbSet.
            _db.Books.Add(book);

            // Save the changes to the database.
            _db.SaveChanges();

            // Redirect to the "Index" action to display the list of books.
            return RedirectToAction("Index");
        }

        // Define a [HttpPost] action method named "Delete" to handle deleting a book.
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            // Find the book with the specified ID in the database.
            var book = await _db.Books.FindAsync(id);
            if (book == null)
            {
                // If the book is not found, return a "Not Found" response.
                return NotFound();
            }

            // Remove the book from the database context's "Books" DbSet.
            _db.Books.Remove(book);

            // Save the changes to the database.
            await _db.SaveChangesAsync();

            // Return an "Ok" response indicating that the book has been deleted.
            return Ok();
        }
    }
}
