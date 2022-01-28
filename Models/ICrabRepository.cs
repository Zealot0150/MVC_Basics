using System.Collections.Generic;

namespace MVC_Basics.Models
{
    public interface ICrabRepository
    {
        IEnumerable<Crab> AllCrabs { get; }
        Crab GetCrabById(int id);
    }
}
