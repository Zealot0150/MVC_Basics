using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using MVC_Basics.Models.Repos;
using MVC_Basics.Models.Services;
using MVC_Basics.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

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

        public IActionResult Delete(int id)
        {
            IActionResult result = null;
            bool userDelted = peopleService.DeleteUser(id);
            result = StatusCode(StatusCodes.Status201Created, userDelted ? "Användare borttagen" : "Användare ej hittad");
            return result;
        }

        public IActionResult List()
        {
            PeopleViewModel pm = new PeopleViewModel();
            pm.PeopleList = peopleService.AllPeople;
            return PartialView("List",pm);        
        
        }

        public IActionResult AddNew2(List<NameValuePair> list)
        {
            // Listan är tom.
            CreatePersonViewModel cpVM = new CreatePersonViewModel();
            try
            {
                // Japp hur jag än gör, så kommer värdet från formet inte in.
                cpVM.Name = list.Find(n => n.Name == "Name").Value;
                cpVM.Tele = list.Find(n => n.Name == "Tele").Value;
                cpVM.City= list.Find(n => n.Name == "City").Value;
            }
            catch (Exception)
            {

            }   
         if (peopleService.AddUser(cpVM))
            return StatusCode(StatusCodes.Status201Created, "Användare tillagd");
         else
            return StatusCode(StatusCodes.Status400BadRequest, "Användare kunde inte läggas till");
        }

        public IActionResult Add() 
        {
            CreatePersonViewModel cpVM = new CreatePersonViewModel();
            return PartialView("Add", cpVM);
        }

    }
}
