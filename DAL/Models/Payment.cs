using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string BankAccountIban { get; set; }
        public string SwiftCode { get; set; }
        public string Terms { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
