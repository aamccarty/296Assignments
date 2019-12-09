using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKidPage.Models;
using Microsoft.EntityFrameworkCore;
using TheKidPage.Repositories;

namespace TheKidPage.Models
{
    public class Repository : IJokes
    {
        private ApplicaitonDbContext context;
        public List<Joke> Jokes { get { return context.Jokes.Include("Users").ToList(); } }

        public Repository(ApplicaitonDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddJoke(Joke joke)
        {
            context.Jokes.Add(joke);
            context.SaveChanges();
        }

        public void AddUser(Joke joke, User user)
        {
            joke.Users.Add(user);
            context.Jokes.Update(joke);
            context.SaveChanges();
        }

        public Joke GetJokeByKeyWord(string title)
        {
            Joke joke;
            joke = context.Jokes.First(b => b.KeyWord == title);
            return joke;
        }

    }
    /*
     public static IEnumerable<Jokes> Responses
     {
         get
         {
             return responses;
         }
     }
     public static void AddResponse(Jokes response)
     {
         responses.Add(response);
     }*/


}

