using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblCategory
    {
        public string CategoryName { get; set; }
        public int? IconId { get; set; }
        public int? ProductId { get; set; }
        public int Id { get; set; }

        public virtual TblProduct Product { get; set; }
    }
}
