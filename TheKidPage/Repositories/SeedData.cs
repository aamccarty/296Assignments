using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheKidPage.Models;
using Microsoft.EntityFrameworkCore;

namespace TheKidPage.Repositories
{
    public class SeedData
    {
        public static void Seed(ApplicaitonDbContext context)
        {
            if (!context.Jokes.Any())
            {
                User user = new User { Name = "Willy Wonka" };
                context.Users.Add(user);

                Joke joke = new Joke
                {
                    KeyWord = "Pirates",
                    JokeLine = "What's a Pirates favorite letter? RRRRRRRR",
                    PubDate = DateTime.Parse("7/24/05")
                };
                joke.Users.Add(user);
                context.Jokes.Add(joke);

                context.SaveChanges(); // save all the data
            }
        }
    }
}
