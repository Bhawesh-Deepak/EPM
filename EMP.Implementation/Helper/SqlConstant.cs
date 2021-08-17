using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Implementation.Helper
{
    public static class SqlConstant
    {
        public static string CreateUser= @"Insert into Authenticat (UserName, Password,CreatedBy) values (@userName, @password,1);";
        public static string IsAuthenticate = @"select COUNT(1) from Authenticat 
                                                where UserName=@username and Password=@password
                                                and IsActive=1 and IsDeleted=0";
    }
}
