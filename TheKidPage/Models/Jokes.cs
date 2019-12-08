using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public class Jokes 
    {
        public int JokeId { get; set; }
        private List<Jokes> jokes = new List<Jokes>();

        public string KeyWord { get; set; }
        public string JokeLine { get; set; }
        public DateTime PubDate { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // EF will use these properties to add BookID FK fields to the Authors and Reviews tables.
        public List<User> Users { get { return Users; } }
        



    }
}
