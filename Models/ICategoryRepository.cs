using System.Collections.Generic;

namespace MVC_Basics.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
