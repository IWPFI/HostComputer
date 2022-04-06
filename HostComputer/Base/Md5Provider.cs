using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Base
{
    public class Md5Provider
    {
        /// <summary>
        /// Gets the m d5 string.
        /// </summary>
        /// <remarks>密码加密</remarks>
        public static string GetMD5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] pws = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            string pwd = "";
            foreach (var item in pws)
            {
                pwd = pwd + item.ToString("X2");
            }
            return pwd;
        }
    }
}
