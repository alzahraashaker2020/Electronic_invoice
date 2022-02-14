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
        public string Ename { get; set; }
        public string Aname { get; set; }

        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
