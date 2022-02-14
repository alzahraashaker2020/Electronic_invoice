using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AddressProperty
    {
        public AddressProperty()
        {
            AddressPropertyEvents = new HashSet<AddressPropertyEvent>();
            AddressPropertyValidations = new HashSet<AddressPropertyValidation>();
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public string Caption { get; set; }
        public int? ControllerId { get; set; }
        public bool? HasValidation { get; set; }

        public virtual InputController Controller { get; set; }
        public virtual ICollection<AddressPropertyEvent> AddressPropertyEvents { get; set; }
        public virtual ICollection<AddressPropertyValidation> AddressPropertyValidations { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
