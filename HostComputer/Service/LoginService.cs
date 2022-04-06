using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostComputer.DataAccess;

namespace HostComputer.Service
{
    public class LoginService
    {
        SqlServerAccess sqlServerAccess = new SqlServerAccess();
        public bool CheckLogin(string username, string password)
        {
            return sqlServerAccess.CheckUserInfo(username, password);
        }
    }
}
