using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? AddressPropId { get; set; }
        public int? UserId { get; set; }
        public int? CountryId { get; set; }

        public virtual AddressProperty AddressProp { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Country Country { get; set; }
        public virtual User User { get; set; }
    }
}
