using APIpoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpoc.Data
{
    public class SqlCategory : ICategory
    {
        private readonly PiyushContext _context;

        public SqlCategory(PiyushContext context)
        {
            _context = context;
        }
        public void CreateCategory(TblCategory category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            _context.TblCategories.Add(category);
            _context.SaveChanges();
        }

        public override bool Equals(object obj)
        {
            return obj is SqlCategory category &&
                   EqualityComparer<PiyushContext>.Default.Equals(_context, category._context);
        }

        public IEnumerable<TblCategory> GetAllCategories()
        {
            return _context.TblCategories.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
