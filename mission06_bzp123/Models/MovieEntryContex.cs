using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_bzp123.Models
{
    public class MovieEntryContex : DbContext
    {
        //this is my contructor, only gets built a singular time
        public MovieEntryContex (DbContextOptions<MovieEntryContex>options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<NewMovieForm> NewMovies { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Romantic Comedy" },
                new Category { CategoryId = 2, CategoryName = "Science Fiction" },
                new Category { CategoryId = 3, CategoryName = "Action" },
                new Category { CategoryId = 4, CategoryName = "Horror" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Fantasy" },
                new Category { CategoryId = 8, CategoryName = "Drama" },
                new Category { CategoryId = 9, CategoryName = "Thriller" },
                new Category { CategoryId = 10, CategoryName = "Musical" },
                new Category { CategoryId = 11, CategoryName = "Romance" },
                new Category { CategoryId = 12, CategoryName = "Mystery" },
                new Category { CategoryId = 13, CategoryName = "See Notes" }
                );
            mb.Entity<NewMovieForm>().HasData(
                new NewMovieForm
                {
                    FormID=1,
                    CategoryId = 10,
                    Title="Mamma Mia!",
                    Year=2008,
                    DirectorFirstName="Phyllida",
                    DirectorLastName="Lloyd",
                    Rating="PG-13",
                    Edited=false,
                    LentTo="My parents",
                    Notes="Fun Musical"
                },
                new NewMovieForm
                {
                    FormID = 2,
                    CategoryId = 2,
                    Title = "The Giver",
                    Year = 2014,
                    DirectorFirstName = "Phillip",
                    DirectorLastName = "Noyce",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Good Vibes"
                },
                new NewMovieForm
                {
                    FormID = 3,
                    CategoryId = 1,
                    Title = "Once I Was Engaged",
                    Year = 2021,
                    DirectorFirstName = "Maclain",
                    DirectorLastName = "Nelson",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "My roommate",
                    Notes = "subversive"
                }
                );
        }
    }
}
