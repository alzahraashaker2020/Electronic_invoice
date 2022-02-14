using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public class ValidationRepo : Base_Repo<Validation>, IValidation
    {
        public ValidationRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
