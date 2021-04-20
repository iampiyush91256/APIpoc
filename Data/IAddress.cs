using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface IAddress
    {
        bool SaveChanges();
        IEnumerable<TblAddress> GetAllAddress();
        void CreateAddress(TblAddress address);
    }
}
