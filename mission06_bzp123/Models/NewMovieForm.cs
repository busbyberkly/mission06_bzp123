using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_bzp123.Models
{
    public class NewMovieForm
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }


    }
}
