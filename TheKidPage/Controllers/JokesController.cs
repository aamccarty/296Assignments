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
        public IActionResult Jokes()
        {
            return View();
        }
        [HttpGet]
        public ViewResult JokeForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult JokeForm(JokeForm jokeform)
        {
            Repository.AddResponse(jokeform);
            return View("Thanks", jokeform);
        }
    }
}