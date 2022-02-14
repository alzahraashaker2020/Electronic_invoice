using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TaxSubType
    {
        public TaxSubType()
        {
            TaxableItems = new HashSet<TaxableItem>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Edescription { get; set; }
        public string Adescription { get; set; }
        public int? TaxTypeId { get; set; }

        public virtual TaxableType TaxType { get; set; }
        public virtual ICollection<TaxableItem> TaxableItems { get; set; }
    }
}
