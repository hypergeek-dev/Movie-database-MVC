using Microsoft.EntityFrameworkCore;
using Movie_database_MVC.Models;
using System;

namespace Movie_database_MVC.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");

            // Data Seedíng
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16), Price = 14.99M },
                new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18), Price = 12.99M },
                new Movie { Id = 3, Title = "Forrest Gump", Genre = "Drama", ReleaseDate = new DateTime(1994, 7, 6), Price = 10.99M }
            );
        }
    }
}