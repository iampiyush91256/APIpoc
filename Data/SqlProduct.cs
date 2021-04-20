using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlProduct : IProduct
    {
        private readonly PiyushContext _context;
        public SqlProduct(PiyushContext context)
        {
            _context = context;
        }
        public void CreateProduct(TblProduct product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            _context.TblProducts.Add(product);
            _context.SaveChanges();
        }


        public override bool Equals(object obj)
        {
            return obj is SqlProduct product &&
                   EqualityComparer<PiyushContext>.Default.Equals(_context, product._context);
        }

        public IEnumerable<TblProduct> GetAllProduct()
        {
            return _context.TblProducts.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
