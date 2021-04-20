using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlAddress : IAddress
    {
        private readonly PiyushContext _context;

        public SqlAddress(PiyushContext piyushContext)
        {
            _context = piyushContext;
        }

        public void CreateAddress(TblAddress address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            _context.TblAddresses.Add(address);
            _context.SaveChanges();
        }



        public IEnumerable<TblAddress> GetAllAddress()
        {
            return _context.TblAddresses.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
