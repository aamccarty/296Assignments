using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public class Joke 
    {
        public int JokeID { get; set; }
        private List<User> users = new List<User>();
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string KeyWord { get; set; }
        
        public string JokeLine { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PubDate { get; set; }

        // EF will use these properties to add BookID FK fields to the Authors and Reviews tables.
        public List<User> Users { get { return users; } }
        
    }




}

