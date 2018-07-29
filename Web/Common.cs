using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Web
{
    public class Common
    {
        public static string Getmd5(string str)
        {
            String s = null;
            Byte[] b = Encoding.Default.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            Byte[] buff = md5.ComputeHash(b);
            foreach (byte item in buff)
            {
                s += item.ToString("x2");
            }
            return s;
        }
    }
}