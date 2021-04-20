using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlUser : IUser
    {
        private readonly PiyushContext _context;

        public SqlUser(PiyushContext context)
        {
            _context = context;
        }
        public void CreateCustomer(TblUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.TblUsers.Add(user);
            _context.SaveChanges();
        }

        public void DeleteCustomer(TblUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.TblUsers.Remove(user);
        }

        public override bool Equals(object obj)
        {
            return obj is SqlUser user &&
                   EqualityComparer<PiyushContext>.Default.Equals(_context, user._context);
        }

        public IEnumerable<TblUser> GetAllCustomer()
        {
            return _context.TblUsers.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
