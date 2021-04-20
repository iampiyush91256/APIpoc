using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface IOrder
    {
        bool SaveChanges();
        IEnumerable<TblOrder> GetAllOrders();
       
    }
}
