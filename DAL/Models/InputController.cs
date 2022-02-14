using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InputController
    {
        public InputController()
        {
            AddressProperties = new HashSet<AddressProperty>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AddressProperty> AddressProperties { get; set; }
    }
}
