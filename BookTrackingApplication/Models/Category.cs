using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApplication.Models
{
    public class Category
    {
        [Key]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string NameToken { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Type { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
