using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheKidPage.Models;

namespace TheKidPage.Controllers
{
    public class JokesController : Controller
    {
        IJokes repo;
        public JokesController(IJokes r)
        {
            repo = r;
        }

        public IActionResult JokesPage()
        {
            List<Joke> jokes = repo.Jokes;
            jokes.Sort((b1, b2) => string.Compare(b1.KeyWord, b2.KeyWord, StringComparison.Ordinal));
            return View(jokes);
        }

        public IActionResult JokeForm()
        {
            return View();
        }


        [HttpPost]
        public RedirectToActionResult JokeForm(string name,
                                              string keyword, string pubDate)
        {
            Joke joke = new Joke { KeyWord = keyword };
            joke.Users.Add(new User() { Name = name });
            /*joke.PubDate = DateTime.Parse(pubDate);*/
            repo.AddJoke(joke);  // this is temporary, in the future the data will go in a database

            return RedirectToAction("Jokespage");
        }


       
    }
    /*public IActionResult Jokespage()
    {
        return View(Repository.responses);
    }
    [HttpGet]
    public ViewResult JokeForm()
    {
        return View();
    }
    [HttpPost]
    public RedirectToActionResult JokeForm(string title,
                                          string author, string pubDate)
    {
        Book book = new Book { Title = title };
        book.Authors.Add(new Author() { Name = author });
        book.PubDate = DateTime.Parse(pubDate);
        repo.AddBook(book);  // this is temporary, in the future the data will go in a database

        return RedirectToAction("Jokespage");
    }
}*/
}