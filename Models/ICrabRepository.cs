using System.Collections.Generic;

namespace MVC_Basics.Models
{
    public interface ICrabRepository
    {
        IEnumerable<Crab> AllCrabs { get; }
        IEnumerable<Crab> CrabsOfTheWeek { get; }
        Crab GetCrabById(int id);
    }
}
