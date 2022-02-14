using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public class ValidationTypeRepo : Base_Repo<ValidationType>, IValidationType
    {
        public ValidationTypeRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
