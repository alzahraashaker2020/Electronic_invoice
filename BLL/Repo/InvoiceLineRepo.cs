using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public class InvoiceLineRepo : Base_Repo<InvoiceLine>, IInvoiceLine
    {
        public InvoiceLineRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
