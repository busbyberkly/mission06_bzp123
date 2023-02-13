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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovieForm>().HasData(
                new NewMovieForm
                {
                    FormID=1,
                    Category="Musical/Romance",
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
                    Category = "Sci-fi",
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
                    Category = "Comedy",
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
