using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveNote.Models
{
    public class CategoryCreate
    {
       [Required]
        public int CategoryId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        public string CategoryTitle { get; set; }
    }
}
