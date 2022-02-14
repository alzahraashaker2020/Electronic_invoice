using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TaxableItem
    {
        public int Id { get; set; }
        public int? TaxTypeId { get; set; }
        public decimal? Amount { get; set; }
        public int? SubTypeId { get; set; }
        public decimal? Rate { get; set; }
        public int? InvoiceLineId { get; set; }

        public virtual InvoiceLine InvoiceLine { get; set; }
        public virtual TaxSubType SubType { get; set; }
        public virtual TaxableType TaxType { get; set; }
    }
}
