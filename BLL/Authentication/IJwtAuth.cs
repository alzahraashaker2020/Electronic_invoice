using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Authentication
{
   public interface IJwtAuth
    {
        string Authentication(string username, string password);
    }
}
