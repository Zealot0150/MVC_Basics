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
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(int guessedNumber)
        {
            try
            {
                // did not found any material about checking if user timed out, so tries with if its null
                if (HttpContext.Session == null)
                {
                    ViewBag.Message = "Logged out, reload page";
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Message = "Logged out";
                return View();
            }
            

            int nrToGuess = Int32.Parse(HttpContext.Session.GetString("number"));
            this.ViewBag.Message = game.Guess(guessedNumber, nrToGuess, out bool won);
            ViewBag.Tries = game.NrTries;
            this.ViewBag.Won = won;

            // check for victory and if so clean the model, the view will show the old.
            if (won)
            {
                string score = "Score " + DateTime.Now.ToString() + " " + game.NrTries;
                if (Request.Cookies["Zealotgame"] != null)
                {
                   score = Request.Cookies["Zealotgame"] + "," + score;
                    Response.Cookies.Delete("Zealotgame");
                }

                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(20);
                Response.Cookies.Append("Zealotgame", score, option);
                ViewBag.Score = score;
                
                HttpContext.Session.SetString("number", random.Next(100) + "");
            }
            return View();
        }

    }
}
