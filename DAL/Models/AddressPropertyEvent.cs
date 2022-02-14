using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AddressPropertyEvent
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public int? AddressPropertyId { get; set; }
        public string Notes { get; set; }

        public virtual AddressProperty AddressProperty { get; set; }
        public virtual Event Event { get; set; }
    }
}
