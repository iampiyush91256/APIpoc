using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlOrder : IOrder
    {
        private readonly PiyushContext _context;
        public SqlOrder(PiyushContext context)
        {
            _context = context;
        }
        
        public override bool Equals(object obj)
        {
            return obj is SqlOrder order &&
                   EqualityComparer<PiyushContext>.Default.Equals(_context, order._context);
        }

        public IEnumerable<TblOrder> GetAllOrders()
        {
            return _context.TblOrders.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
