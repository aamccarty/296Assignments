using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public interface IJokes
    {
        List<Jokes> Jokes { get; }
        void AddJoke(Jokes joke);
        void AddUser(Jokes joke, User user);
        Jokes GetJokeByLetter(string title);
    }
}

