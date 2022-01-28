using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using System;

namespace MVC_Basics.Controllers
{
    public class GameController : Controller
    {
        static Random random = new Random();
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("number")))
            {
                HttpContext.Session.SetString("number", random.Next(100) + "");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(int guessedNumber)
        {
            
            int nrToGuess = Int32.Parse(HttpContext.Session.GetString("number"));
            this.ViewBag.Message = Game.Guess(guessedNumber, nrToGuess, out bool won);
            ViewBag.Tries = Game.NrTries;
            this.ViewBag.Won = won;
            // check for victory and if so clean the model, the view will show the old.
            if (won)
            {
                string score = "Score " + DateTime.Now.ToString() + " " + Game.NrTries;
                if (Request.Cookies["Zealotgame"] != null)
                {
                   score = Request.Cookies["Zealotgame"] + "," + score;
                    Response.Cookies.Delete("Zealotgame");

                }
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("Zealotgame", score, option);
                ViewBag.Score = score;
                Game.Reset();
                HttpContext.Session.SetString("number", random.Next(100) + "");
            }
            return View();
        }

    }
}
