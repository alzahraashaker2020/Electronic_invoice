using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UniteValue
    {
        public UniteValue()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public int Id { get; set; }
        public string CurrencySold { get; set; }
        public decimal? AmountEgp { get; set; }
        public decimal? AmountSold { get; set; }
        public decimal? CurrencyExchangeRate { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
