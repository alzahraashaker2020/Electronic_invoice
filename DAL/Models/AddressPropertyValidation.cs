using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AddressPropertyValidation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ValidationId { get; set; }
        public int? AddressPropertyId { get; set; }
        public string Value { get; set; }

        public virtual AddressProperty AddressProperty { get; set; }
        public virtual Validation Validation { get; set; }
    }
}
