using System.Collections.Generic;
using System.Linq;

namespace MVC_Basics.Models
{
    public class MochCrabRepository : ICrabRepository
    {
        private readonly ICategoryRepository categoryRepository = new MochCategoryRepository();

        public IEnumerable<Crab> AllCrabs =>
        new List<Crab>
            {
                new Crab{CrabID = 1, Name="Brown crab", Description=
                    "Description browncrab", Price=1.0, ImageUrl=@"https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80"},
                new Crab{CrabID = 2, Name="Blue crab", Description=
                    "Description Bluecrab", Price=1.5, ImageUrl=@"https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80"},
                new Crab{CrabID = 3, Name="Red crab", Description=
                    "Description Redcrab", Price=2, ImageUrl=@"https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80"},
                new Crab{CrabID = 4, Name="Browner crab", Description=
                    "Description browncrab", Price=1.0, ImageUrl=@"https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80"},
                new Crab{CrabID = 5, Name="Bluer crab", Description=
                    "Description Bluecrab", Price=1.5, ImageUrl=@"https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80"},
                new Crab{CrabID = 6, Name="Reder crab", Description=
                    "Description Redcrab", Price=2, ImageUrl=@"https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80"}





        };

        public Crab GetCrabById(int id)
        {
            return AllCrabs.FirstOrDefault(c => c.CrabID == id);
        }
    }
}
