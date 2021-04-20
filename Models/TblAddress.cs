using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblAddress
    {
        public TblAddress()
        {
            TblCheckouts = new HashSet<TblCheckout>();
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string LandMark { get; set; }
        public string PinCode { get; set; }
        public string PhoneNo { get; set; }

        public virtual ICollection<TblCheckout> TblCheckouts { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
