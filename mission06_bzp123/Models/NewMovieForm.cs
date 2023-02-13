using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_bzp123.Models
{
    public class NewMovieForm
    {
        //Primary Key
        [Key]
        [Required]
        public int FormID { get; set; }
        
        //These fields are required in order to submit the form
        [Required(ErrorMessage = "{0} is required")]
        public string Category { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public int Year { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public string DirectorFirstName { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public string DirectorLastName { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public string Rating { get; set; }
        
        //these fields are not required
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        //making it so notes cannot be longer than 25 characters
        [StringLength(25)]
        public string Notes { get; set; }


    }
}
