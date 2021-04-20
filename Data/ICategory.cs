using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface ICategory
    {
        bool SaveChanges();

        IEnumerable<TblCategory> GetAllCategories();
        void CreateCategory(TblCategory category);
    }
}
