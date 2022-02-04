using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using MVC_Basics.Models.Services;
using MVC_Basics.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Controllers
{


    public class AjaxController : Controller
    {
        private readonly IServicePeople peopleService;

        public AjaxController(IServicePeople peopleService)
        {
            this.peopleService = peopleService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details(int id)
        {
            People p = peopleService.GetUSer(id);
            return PartialView("Details",p);
        }

        public IActionResult Deletex(int id)
        {
            bool userDelted = peopleService.DeleteUser(id);
            DeleteVievModel dvm = new() { Result = userDelted ? "User Deleted" : "User not found" };
            return PartialView("Deletex",dvm);
        }

        public IActionResult List()
        {
            PeopleViewModel pm = new PeopleViewModel();
            pm.PeopleList = peopleService.AllPeople;
            return PartialView("List",pm);        
        }
    }
}
