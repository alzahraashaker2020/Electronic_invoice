using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public class AddressPropertyEventRepo : Base_Repo<AddressPropertyEvent>, IAddressPropertyEvent
    {
        public AddressPropertyEventRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
