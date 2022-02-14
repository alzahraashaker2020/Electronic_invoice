using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Document
    {
        public Document()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
        }

        public int Id { get; set; }
        public int IssuerId { get; set; }
        public int ReceiverId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeVersion { get; set; }
        public DateTime DateTimeIssued { get; set; }
        public string TaxpayerActivCode { get; set; }
        public string InternalId { get; set; }
        public string PurchaseOrderRef { get; set; }
        public string PurchaseOrderDescrip { get; set; }
        public string SalesOrderRef { get; set; }
        public string SalesOrderDescrip { get; set; }
        public string ProformaInvoiceNumber { get; set; }
        public int? PaymentId { get; set; }
        public int? DeliveryId { get; set; }
        public decimal? TotaSalesAmount { get; set; }
        public decimal? TotalDiscAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? ExtraDiscAmount { get; set; }
        public decimal? TotalItemDiscAmount { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Delivery Delivery { get; set; }
        public virtual User Issuer { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual User Receiver { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    }
}
