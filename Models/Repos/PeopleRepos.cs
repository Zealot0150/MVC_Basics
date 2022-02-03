using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Basics.Models.Services;
using System.Linq.Expressions;
using MVC_Basics.ViewModels;

namespace MVC_Basics.Models.Repos
{
    public class PeopleRepos:IServicePeople
    {
        private readonly AppDbContext appDbContext;
        public PeopleRepos(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;

        }

        IEnumerable<People> IServicePeople.AllPeople
        {
            get
            {
                return appDbContext.People;
            }
        }

        bool IServicePeople.AddUser(CreatePersonViewModel peopleVM)
        {
            throw new NotImplementedException();
        }

        bool IServicePeople.DeleteUser(int id)
        {
            try
            {
                List<People> list = appDbContext.People.ToList();
                People p = list.First(p => p.Id == id);
                appDbContext.People.Remove(p);
                appDbContext.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        IEnumerable<People> IServicePeople.SearchPeople(string searchText)
        {
            List<People> list = appDbContext.People.ToList();
            list = list.Where(s => s.City.Contains(searchText)
                            || s.Id.ToString().Contains(searchText)
                            || s.Tele.Contains(searchText)
                            || s.Name.ToString().Contains(searchText)
                            ).ToList();
            return list;
        }
    }
}
