using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface IProduct
    {
        bool SaveChanges();
        IEnumerable<TblProduct> GetAllProduct();
        void CreateProduct(TblProduct product);
      
    }
}
