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
    }
}
