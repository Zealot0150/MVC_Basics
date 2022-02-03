using System.Collections.Generic;
using MVC_Basics.ViewModels;

namespace MVC_Basics.Models.Services
{
    public interface IServicePeople
    {
        public IEnumerable<People> AllPeople { get; }


        public IEnumerable<People> SearchPeople(string searchText);



        public bool DeleteUser(int id);

        public bool AddUser(CreatePersonViewModel peopleVM);

    }
}
