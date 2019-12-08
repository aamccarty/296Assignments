using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public class JokeForm
    {
        public int JokeFormID { get; set; }
        private List<Jokes> jokes = new List<Jokes>();
        private List<User> user = new List<User>();

        public string Letter { get; set; }
        public DateTime PubDate { get; set; }

        // EF will use these properties to add BookID FK fields to the Authors and Reviews tables.
        public List<Jokes> Jokes { get { return jokes; } }
        public List<User> User { get { return user; } }

    }
}
