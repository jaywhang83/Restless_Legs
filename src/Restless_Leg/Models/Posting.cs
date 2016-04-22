using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restless_Leg.Models
{
    public class Posting
    {
        [Key]
        public int PostingId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; } 
    }
}
