using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmTavsiye.Models.DbModels;

namespace FilmTavsiye.Models.Enums
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host = localhost; Database = moviedb; Username = postgres; Password = 123");
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
