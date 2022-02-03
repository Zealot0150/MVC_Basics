using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using MVC_Basics.Models.Services;
using MVC_Basics.Models.Repos;
using MVC_Basics.ViewModels;

namespace MVC_Basics.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IServicePeople peopleService;
         
        public PeopleController(IServicePeople peopleService)
        {
            this.peopleService = peopleService;
        }


        public IActionResult Index(PeopleViewModel model)
        {
            if (model == null || model.PeopleList == null )
            {
                PeopleViewModel peopleVM = new PeopleViewModel();
                peopleVM.PeopleList = peopleService.AllPeople;
                return View(peopleVM);
            }
            else
                return View(model);
        }
        //[HttpPost]
        //public IActionResult Index(PeopleViewModel model)
        //{
        //    return View(model);
        //}



        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new CreatePersonViewModel());
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreatePersonViewModel createViewModel)
        {
            if (ModelState.IsValid)
            {
                peopleService.AddUser(createViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(createViewModel);
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            peopleService.DeleteUser(Id);   
            return RedirectToAction(nameof(Index));
        }

       
        public IActionResult Search(string Id)
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.PeopleList = peopleService.SearchPeople(Id);
            return Index(peopleVM);
            //return RedirectToAction(nameof(Index), new { peopleVM});
        }

    }
}
