using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public class AddressPropertyValidationRepo : Base_Repo<AddressPropertyValidation>, IAddressPropertyValidation
    {
        public AddressPropertyValidationRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
