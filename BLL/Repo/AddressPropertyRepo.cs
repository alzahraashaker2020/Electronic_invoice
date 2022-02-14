using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AddressPropertyRepo : Base_Repo<AddressProperty>, IAddressProperty
    {
        public AddressPropertyRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }


    }
}
