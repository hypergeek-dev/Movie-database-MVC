using Microsoft.EntityFrameworkCore;
using Movie_database_MVC.Models;

namespace Movie_database_MVC.Data  
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
