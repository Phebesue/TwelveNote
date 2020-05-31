using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveNote.Models
{
    public class NoteItemList
    {
        public int NoteId { get; set; }
        public string  NoteTitle { get; set; }
        public string CategoryTitle { get; set; }
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
