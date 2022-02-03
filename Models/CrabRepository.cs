using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class CrabRepository : ICrabRepository
    {
        private readonly AppDbContext appDbContext;
        public CrabRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        IEnumerable<Crab> ICrabRepository.AllCrabs
        {
            get {
                return appDbContext.Crabs;
            }
        }

        public IEnumerable<Crab> CrabsOfTheWeek
        {
            get
            {
                return appDbContext.Crabs.Where(cr => cr.IsCrabOfTheWeek == true);
            }
        }
       
        Crab ICrabRepository.GetCrabById(int id)
        {
            return appDbContext.Crabs.FirstOrDefault(c => c.CrabID == id);
        }
    }
}
