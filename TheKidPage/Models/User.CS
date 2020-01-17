using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string Phone { get; set; }

    }
}
