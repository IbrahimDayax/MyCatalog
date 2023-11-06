using MySql.Data.EntityFrameworkCore; // Import the MySQL Entity Framework Core namespace.
using Microsoft.EntityFrameworkCore; // Import the Entity Framework Core namespace.
using MyCatalog.Models; // Import the namespace where your model (BooksEntity) is defined.

namespace MyCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Constructor for the ApplicationDbContext class.
            // It accepts database context options when the context is created.
        }

        public DbSet<BooksEntity> Books { get;set;}
        // This property represents the 'Books' table in the database.
        // It allows you to interact with this table using Entity Framework Core.
    }
}
