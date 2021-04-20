using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public interface IUser
    {
        bool SaveChanges();
        IEnumerable<TblUser> GetAllCustomer();
        void CreateCustomer(TblUser user);
        void DeleteCustomer(TblUser user);

    }
}
