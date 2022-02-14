using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ValidationType
    {
        public ValidationType()
        {
            Validations = new HashSet<Validation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Validation> Validations { get; set; }
    }
}
