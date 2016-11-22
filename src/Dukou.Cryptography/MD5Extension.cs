using Dukou.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography
{
    public static class MD5Extension
    {
        public static string MD5Encrypt(this string source, string key)
        {
            return MD5Encrypt(source, key, null);
        }

        public static string MD5Encrypt(this string source, string key, string salt)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes($"{source}&key={key}{(string.IsNullOrEmpty(salt) ? string.Empty : $"&salt={salt}")}");
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            return bytes.ToString(StringFormatTypes.HEX);
        }
    }
}
