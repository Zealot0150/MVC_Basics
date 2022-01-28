using System;
using System.Collections.Generic;

namespace MVC_Basics.Models
{
    public class MochCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
