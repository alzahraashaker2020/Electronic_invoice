using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InvoiceLine
    {
        public InvoiceLine()
        {
            TaxableItems = new HashSet<TaxableItem>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public int? UnitTypeId { get; set; }
        public decimal? Quantity { get; set; }
        public int? UnitValueId { get; set; }
        public decimal? SalesTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? ValueDifference { get; set; }
        public decimal? TotalTaxableFees { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? ItemsDiscount { get; set; }
        public int? DiscountId { get; set; }
        public string InternalCode { get; set; }
        public int? DocumentId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Document Document { get; set; }
        public virtual UniteType UnitType { get; set; }
        public virtual UniteValue UnitValue { get; set; }
        public virtual ICollection<TaxableItem> TaxableItems { get; set; }
    }
}
