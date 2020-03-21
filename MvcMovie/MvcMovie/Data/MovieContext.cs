using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        //DbSet<Movie> property the entity set "database table"
        //An entity corresponds to a row in the table
        public DbSet<Movie> Movie { get; set; }
    }
}
