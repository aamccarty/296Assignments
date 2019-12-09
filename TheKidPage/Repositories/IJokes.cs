using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheKidPage.Models
{
    public interface IJokes
    {
        List<Joke> Jokes { get; }
        void AddJoke(Joke joke);
        void AddUser(Joke joke, User user);
        Joke GetJokeByKeyWord(string title); 
    }
}

