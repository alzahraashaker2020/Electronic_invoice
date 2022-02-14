using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Edescription { get; set; }
        public string Adescription { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
