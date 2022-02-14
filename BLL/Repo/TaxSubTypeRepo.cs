using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class TaxSubTypeRepo : Base_Repo<TaxSubType>, ITaxSubType
    {
        public TaxSubTypeRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
