using System;
using System.Collections.Generic;

#nullable disable

namespace APIpoc.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Ipaddr { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string Statuss { get; set; }

        public virtual TblAddress Address { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
