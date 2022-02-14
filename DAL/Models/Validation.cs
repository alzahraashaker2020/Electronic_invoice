using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Validation
    {
        public Validation()
        {
            AddressPropertyValidations = new HashSet<AddressPropertyValidation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? HasValue { get; set; }
        public int? ValidationTypeId { get; set; }
        public string ControllerNames { get; set; }

        public virtual ValidationType ValidationType { get; set; }
        public virtual ICollection<AddressPropertyValidation> AddressPropertyValidations { get; set; }
    }
}
