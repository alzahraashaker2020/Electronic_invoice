using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Discount
    {
        public Discount()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public int Id { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
