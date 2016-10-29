using System;

namespace Dukou.Cryptography
{
    /// <summary>
    /// byte数组扩展方法
    /// </summary>
    public static class ByteArrayExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="formatType"></param>
        /// <returns></returns>
        public static String ToString(this byte[] bytes, StringFormatType formatType)
        {
            return ToString(bytes, formatType, "UTF-8");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="formatType"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static String ToString(this byte[] bytes, StringFormatType formatType, String charset)
        {
            if (formatType == StringFormatType.BASE64)
            {
                return Convert.ToBase64String(bytes);
            }
            else if (formatType == StringFormatType.HEX)
            {
                return BitConverter.ToString(bytes).Replace("-", "");
            }
            else 
            {
                return System.Text.Encoding.GetEncoding(charset).GetString(bytes);
            }
        }

        /// <summary>
        /// 数组反转
        /// </summary>
        /// <param name="bytes">byte数组</param>
        /// <returns></returns>
        public static byte[] Reverse(this byte[] bytes)
        {
            Array.Reverse(bytes);
            return bytes;
        }
    }
}
