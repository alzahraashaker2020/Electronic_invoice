using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Event
    {
        public Event()
        {
            AddressPropertyEvents = new HashSet<AddressPropertyEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }

        public virtual ICollection<AddressPropertyEvent> AddressPropertyEvents { get; set; }
    }
}
