using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class DoctorController : Controller
    {
        private Patient patient = new Patient(); 

        public IActionResult CheckPerson()
        {
            return View(patient);
        }
        [HttpPost]
        public IActionResult CheckPerson(int temp, string scale)
        {
            ViewBag.Message = patient.CheckPerson(temp, scale);
            return View(patient);
        }
    }
}
