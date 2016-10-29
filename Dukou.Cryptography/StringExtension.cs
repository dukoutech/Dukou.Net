using System;

namespace Dukou.Cryptography
{
    public static class StringExtension
    {
        /// <summary>
        /// 源字符串转化为字节数组
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="formatType">源字符串的字符串格式类型</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArray(this String source, StringFormatType formatType)
        {
            return source.ToByteArray(formatType, "UTF-8");
        }

        /// <summary>
        /// 源字符串转化为字节数组
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="formatType">源字符串的字符串格式类型</param>
        /// <param name="charset">字符集</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArray(this String source, StringFormatType formatType, String charset)
        {
            if (formatType == StringFormatType.BASE64)
            {
                return Convert.FromBase64String(source);
            }
            else if (formatType == StringFormatType.HEX)
            {
                int len = source.Length;
                byte[] bytes = new byte[len / 2];
                for (int i = 0; i < len; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(source.Substring(i, 2), 16);
                }

                return bytes;
            }
            else
            {
                return System.Text.Encoding.GetEncoding(charset).GetBytes(source);
            }
        }

        /// <summary>
        /// 源字符串转化为指定字符串格式类型的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="formatType">字符串格式类型</param>
        /// <returns>指定字符串格式类型的字符串</returns>
        public static String ToString(this String source, StringFormatType formatType)
        {
            return ToString(source, formatType, "UTF-8");
        }

        /// <summary>
        /// 源字符串转化为指定字符串格式类型的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="formatType">字符串格式类型</param>
        /// <param name="charset">字符集类型</param>
        /// <returns>指定字符串格式类型的字符串</returns>
        public static String ToString(this String source, StringFormatType formatType, String charset)
        {
            if (formatType == StringFormatType.BASE64)
            {
                return Convert.ToBase64String(source.ToByteArray(formatType, charset));
            }
            else if (formatType == StringFormatType.HEX)
            {
                return source.ToByteArray(StringFormatType.None, charset).ToString(formatType);
            }

            return source;
        }

        public static int GetByteCount(this String source)
        {
            return source.GetByteCount("UTF-8");
        }

        public static int GetByteCount(this String source, String charset)
        {
            return System.Text.Encoding.GetEncoding(charset).GetByteCount(source);
        }
   }
}
