using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingApplication.Models
{
    public class CategoryType
    {
        [Key]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Type { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

    }
}
