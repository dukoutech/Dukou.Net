using System;
using System.IO;
using System.Security.Cryptography;

namespace Dukou.Cryptography
{
    /// <summary>
    /// 加密扩展
    /// </summary>
    public static class CryptographyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESEncrypt(this String source, String key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            cryptoServiceProvider.Mode = cipherMode;
            cryptoServiceProvider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateEncryptor(key.ToByteArray(StringFormatType.None), key.ToByteArray(StringFormatType.None)), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(StringFormatType.None);
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }

        public static byte[] DESDecrypt(this String source, String key, StringFormatType formatType = StringFormatType.BASE64, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            cryptoServiceProvider.Mode = cipherMode;
            cryptoServiceProvider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateDecryptor(key.ToByteArray(StringFormatType.None), key.ToByteArray(StringFormatType.None)), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(formatType);
     
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// 3DES
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeEncrypt(this String source, String key, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            return source.DESedeEncrypt(key, key, cipherMode, paddingMode);
        }

        /// <summary>
        /// 3DES
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        /// <returns></returns>
        public static byte[] DESedeEncrypt(this String source, String key, String iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Mode = cipherMode;
            tripleDESCryptoServiceProvider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] rgbKey = key.ToByteArray(StringFormatType.BASE64);
                byte[] rgbIV = iv.ToByteArray(StringFormatType.BASE64);
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(StringFormatType.None);
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }

        public static byte[] DESedeDecrypt(this String source, String key, StringFormatType formatType = StringFormatType.BASE64, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Mode = cipherMode;
            tripleDESCryptoServiceProvider.Padding = paddingMode;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] rgbKey = key.ToByteArray(StringFormatType.BASE64);
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(rgbKey, rgbKey), CryptoStreamMode.Write))
                {
                    byte[] buffer = source.ToByteArray(formatType);

                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }

                return memoryStream.ToArray();
            }
        }

        public static String MD5Encrypt(this String source)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(source);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }

            return ret.PadLeft(32, '0');
        }
    }
}
