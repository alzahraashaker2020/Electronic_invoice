using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UniteType
    {
        public UniteType()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Desc_en { get; set; }
        public string Desc_ar { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
