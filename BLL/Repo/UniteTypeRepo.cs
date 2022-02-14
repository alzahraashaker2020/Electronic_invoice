using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   
    public class UniteTypeRepo : Base_Repo<UniteType>, IUniteType
    {
        public UniteTypeRepo(Invoice_ElectronicContext dbContextInv) : base(dbContextInv)
        {

        }
    }
}
