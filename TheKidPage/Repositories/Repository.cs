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
        public static List<Jokes> responses = new List<Jokes>();

        private ApplicaitonDbContext context;
        public List<Jokes> Jokes { get { return context.Jokes.Include("User").ToList(); } }

        public Repository(ApplicaitonDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public void AddJoke(Jokes jokes)
        {
            context.Jokes.Add(jokes);
            context.SaveChanges();
        }

        public void AddUser(User user)
        {
            user.User.Add(user);
            context.Joke.Update(user);
            context.SaveChanges();
        }

        public Jokes GetJokesByLetter(char letter)
        {
            Jokes jokes;
            jokes = context.Jokes.First(b => b.KeyWord.First == letter);
            return jokes;
        }
        public static IEnumerable<JokeForm> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(JokeForm response)
        {
            responses.Add(response);
        }
    }
}
