using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Approach { get; set; }
        public string Packaging { get; set; }
        public DateTime? DateValidity { get; set; }
        public string ExportPort { get; set; }
        public string CountryOfOrigin { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public string Terms { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
