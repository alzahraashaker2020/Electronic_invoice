using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
