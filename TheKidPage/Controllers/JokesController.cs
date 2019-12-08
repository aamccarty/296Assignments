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
            return View(Repository.Responses);
        }
        [HttpGet]
        public ViewResult JokeForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult JokeForm(Jokes jokes)
        {
            Repository.AddResponse(jokes);
            return View("Jokes", jokes);
        }
    }
}