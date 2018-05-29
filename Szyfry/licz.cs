using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfry
{
    class licz
    {
        #region szyfrowanie
        public static string MD5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string SHA1(string s)
        {
            using (var provider = System.Security.Cryptography.SHA1.Create())
            {

                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string SHA256(string s)
        {
            using (var provider = System.Security.Cryptography.SHA256.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string SHA384(string s)
        {
            using (var provider = System.Security.Cryptography.SHA384.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        public static string SHA512(string s)
        {
            using (var provider = System.Security.Cryptography.SHA512.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
        #endregion
        #region odszyfrowywanie
        #endregion
    }    
}

