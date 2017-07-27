using System.Data.Entity;

namespace MvcTutorial.Models
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}