using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class CategoryRepositary : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepositary(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        IEnumerable<Category> ICategoryRepository.AllCategories
        {
            get
            {
                return appDbContext.Categories;
            }
        }
    }
}
