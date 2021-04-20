using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblCheckouts = new HashSet<TblCheckout>();
        }

        public int Id { get; set; }
        public string UserFirstName { get; set; }
        public string UserMiddleName { get; set; }
        public string UserLastName { get; set; }
        public int UserId { get; set; }
        public int? ProductId { get; set; }
        public decimal? OrderTotal { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual TblProduct Product { get; set; }
        public virtual TblUser ProductNavigation { get; set; }
        public virtual ICollection<TblCheckout> TblCheckouts { get; set; }
    }
}
