using Microsoft.EntityFrameworkCore;

namespace BookConsole.Data
{
    // Defining a class for managing a database context
    public class BookContext : DbContext
    {
        // Defining a DbSet for storing Book objects in the database
        public DbSet<Models.Book> volumeInfo { get; set; }

        // Overrides the OnConfiguring method to specify the database provider and connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configures the context to use SQL Server as the database provider
            optionsBuilder.UseSqlServer("ConnectionString");
        }
    }
}

