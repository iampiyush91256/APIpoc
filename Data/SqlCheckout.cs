using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlCheckout : ICheckout
    {
        private readonly PiyushContext _context;

        public SqlCheckout(PiyushContext context)
        {
            _context = context;
        }
        public void CreateCheckout(TblCheckout checkout)
        {
            
            if (checkout == null)
               throw new ArgumentNullException(nameof(checkout));

             _context.TblCheckouts.Add(checkout);
             _context.SaveChanges();
        }

        public void DeleteCheckout(TblCheckout checkout)
        {
            if (checkout == null)
                throw new ArgumentNullException(nameof(checkout));

            _context.TblCheckouts.Remove(checkout);
        }

        public override bool Equals(object obj)
        {
            return obj is SqlCheckout checkout &&
                   EqualityComparer<PiyushContext>.Default.Equals(_context, checkout._context);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
