using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApplication.Models
{
    public class Book
    {
        [Key]
        [Required]
        [StringLength(13, MinimumLength = 10)]
        public string ISBN { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Category { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
    }
}
