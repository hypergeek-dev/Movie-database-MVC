using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Movie_database_MVC.Data;
using System;

namespace Movie_database_MVC.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
    {
        public MovieDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieDbContext>();
            optionsBuilder.UseSqlServer("Server = localhost; Database = MovieDB; Trusted_Connection = True; MultipleActiveResultSets = true");

            return new MovieDbContext(optionsBuilder.Options);
        }
    }
}