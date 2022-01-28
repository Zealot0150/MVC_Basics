using System.Collections.Generic;

namespace MVC_Basics.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Crab> Crabs { get; set; }
    }
}
