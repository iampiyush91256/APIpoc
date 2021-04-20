using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblSubCategory
    {
        public string SubCatName { get; set; }
        public int? ProductId { get; set; }
        public int Id { get; set; }

        public virtual TblProduct Product { get; set; }
    }
}
