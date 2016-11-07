using Dukou.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public static class DESedeExtension
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeEncrypt(this string source, string key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return DESedeEncrypt(source, key, key, cipherMode, paddingMode);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeEncrypt(this string source, string key, string iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            var provider = new TripleDESCryptoServiceProvider();
            provider.Mode = cipherMode;
            provider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] rgbKey = key.ToByteArray(StringFormatTypes.BASE64);
                byte[] rgbIV = iv.ToByteArray(StringFormatTypes.BASE64);
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, provider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(StringFormatTypes.None);
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="sourceFormatType"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeDecrypt(this string source, string key, StringFormatTypes sourceFormatType = StringFormatTypes.BASE64, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return DESedeDecrypt(source, key, key, sourceFormatType, cipherMode, paddingMode);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <param name="sourceFormatType"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeDecrypt(this string source, string key, string iv, StringFormatTypes sourceFormatType = StringFormatTypes.BASE64, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            var provider = new TripleDESCryptoServiceProvider();
            provider.Mode = cipherMode;
            provider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] rgbKey = key.ToByteArray(StringFormatTypes.BASE64);
                byte[] rgbIV = iv.ToByteArray(StringFormatTypes.BASE64);
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, provider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(sourceFormatType);

                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }
    }
}
