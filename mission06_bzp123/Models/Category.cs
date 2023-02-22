using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_bzp123.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage ="Category is Required.")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
