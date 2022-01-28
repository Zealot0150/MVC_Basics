using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using MVC_Basics.ViewModels;

namespace MVC_Basics.Controllers
{
    public class CrabController : Controller
    {
        private readonly ICrabRepository crabRepository;// = new MochCrabRepository();
        private readonly ICategoryRepository categoryRepository;



        public CrabController(ICrabRepository crabRepository, ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.crabRepository = crabRepository;
        }
        public IActionResult Crab()
        {
            ViewBag.Message = "Nu är det dags att handla";
            CrabListViewmodel CM = new CrabListViewmodel();
            CM.Crabs = crabRepository.AllCrabs;
            CM.CurrentCategegory = "Red Crabs";
            return View(CM);
        }
    }
}
