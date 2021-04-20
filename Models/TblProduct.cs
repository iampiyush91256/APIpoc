using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblCategories = new HashSet<TblCategory>();
            TblOrders = new HashSet<TblOrder>();
            TblProductImages = new HashSet<TblProductImage>();
            TblSubCategories = new HashSet<TblSubCategory>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int ImageId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<TblCategory> TblCategories { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
        public virtual ICollection<TblProductImage> TblProductImages { get; set; }
        public virtual ICollection<TblSubCategory> TblSubCategories { get; set; }
    }
}
