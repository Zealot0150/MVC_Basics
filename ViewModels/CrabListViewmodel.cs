using MVC_Basics.Models;
using System.Collections.Generic;

namespace MVC_Basics.ViewModels
{
    public class CrabListViewmodel
    {
        public IEnumerable<Crab> Crabs { get; set; }
        public string CurrentCategegory { get; set; }

    }
}
