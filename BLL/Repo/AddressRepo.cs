using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AddressRepo : Base_Repo<Address>, IAddress
    {
        public AddressRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }


    }
}
