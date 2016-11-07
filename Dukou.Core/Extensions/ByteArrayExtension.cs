using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Extensions
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
        /// <param name="destFormatType">目标字符串格式类型</param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string ToString(this byte[] bytes, StringFormatTypes destFormatType = StringFormatTypes.None, string charset = "UTF-8")
        {
            if (destFormatType == StringFormatTypes.BASE64)
            {
                return Convert.ToBase64String(bytes);
            }
            else if (destFormatType == StringFormatTypes.HEX)
            {
                return string.Join(string.Empty, bytes.Select(x => x.ToString("X2")));
                //return BitConverter.ToString(bytes).Replace("-", "");
            }
            else
            {
                return Encoding.GetEncoding(charset).GetString(bytes);
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
