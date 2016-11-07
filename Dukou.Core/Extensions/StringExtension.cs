using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 获取字符串字节数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static int GetByteCount(this string source, string charset = "UTF-8")
        {
            return Encoding.GetEncoding(charset).GetByteCount(source);
        }

        /// <summary>
        /// 源字符串转化为字节数组
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="sourceFormatType">源字符串的字符串格式类型</param>
        /// <param name="charset">字符集</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArray(this string source, StringFormatTypes sourceFormatType = StringFormatTypes.None, string charset = "UTF-8")
        {
            if (sourceFormatType == StringFormatTypes.BASE64)
            {
                return Convert.FromBase64String(source);
            }
            else if (sourceFormatType == StringFormatTypes.HEX)
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
                return Encoding.GetEncoding(charset).GetBytes(source);
            }
        }

        /// <summary>
        /// 源字符串转化为指定字符串格式类型的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="sourceFormatType">源字符串格式类型</param>
        /// <param name="destFormatType">目标字符串格式类型</param>
        /// <param name="charset">字符集类型</param>
        /// <returns>指定字符串格式类型的字符串</returns>
        public static string ToString(this string source, StringFormatTypes sourceFormatType = StringFormatTypes.None, StringFormatTypes destFormatType = StringFormatTypes.None, string charset = "UTF-8")
        {
            return source.ToByteArray(sourceFormatType, charset).ToString(destFormatType, charset);
        }

    }
}
