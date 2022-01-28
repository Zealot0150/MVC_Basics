using Microsoft.AspNetCore.Mvc;


namespace MVC_Basics.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
    }
}
