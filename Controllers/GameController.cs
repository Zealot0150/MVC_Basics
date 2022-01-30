using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using System;

namespace MVC_Basics.Controllers
{
    public class GameController : Controller
    {
        private Game game = new Game();
        static Random random = new Random();
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("number")))
            {
                HttpContext.Session.SetString("number", random.Next(100) + "");
                HttpContext.Session.SetString("nrOfGuess", "0");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(int guessedNumber)
        {
            string strToGuess = HttpContext.Session.GetString("number");
            string nrOfGuess = HttpContext.Session.GetString("nrOfGuess");
            if ((string.IsNullOrEmpty(strToGuess))||(string.IsNullOrEmpty(nrOfGuess)))
            {
                ViewBag.Message = "Game timed out, reload page";
                return View();
            }

            int nrToGuess = Int32.Parse(strToGuess);
            int nrTries = Int32.Parse(nrOfGuess);

            this.ViewBag.Message = game.Guess(guessedNumber, nrToGuess, out bool won);
            ViewBag.Tries = ++nrTries;
            HttpContext.Session.SetString("nrOfGuess",nrTries +"");

            this.ViewBag.Won = won;

            // check for victory and if so clean the model, the view will show the old.
            if (won)
            {
                string score = "Score " + DateTime.Now.ToString() + " " + nrTries;
                if (Request.Cookies["Zealotgame"] != null)
                {
                   score = Request.Cookies["Zealotgame"] + "," + score;
                    Response.Cookies.Delete("Zealotgame");
                }

                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(20);
                Response.Cookies.Append("Zealotgame", score, option);
                ViewBag.Score = score;
                HttpContext.Session.SetString("nrOfGuess", "0");
                HttpContext.Session.SetString("number", random.Next(100) + "");
            }
            return View();
        }

    }
}
