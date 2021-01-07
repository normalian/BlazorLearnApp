using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearnApp.Models
{
    public class Restaurant
    {
        [Required]
        [StringLength(100, ErrorMessage = "Input restaurant name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Input City name")]
        public string City { get; set; }

        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "Input State Name")]
        public string State { get; set; }
    }
}
