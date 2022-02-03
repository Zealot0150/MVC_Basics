using System.Collections.Generic;
using MVC_Basics.Models;

namespace MVC_Basics.ViewModels
{
    public class PeopleViewModel
    {
        public IEnumerable<People> PeopleList { get; set; }
        public string SearchCriteria { get; set; }
        
        public int UserToDelete { get; set; } 

    }
}
