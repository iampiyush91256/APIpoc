using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface ICheckout
    {
        bool SaveChanges();
        void CreateCheckout(TblCheckout checkout);
        void DeleteCheckout(TblCheckout checkout);
    }
}
