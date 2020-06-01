using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string NoteTitle { get; set; }
         
        public int CategoryId { get; set; }
        [Required] 
        public string Content { get; set; }
        [Required] 
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
