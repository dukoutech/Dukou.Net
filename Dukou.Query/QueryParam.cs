using System;
using System.Globalization;

namespace Dukou.Query
{
    /// <summary>
    /// 查询参数
    /// </summary>
    public class QueryParam
    {
        public QueryParam() { }

        public QueryParam(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public string Value { get; set; }

        public DateTime DateTimeValue()
        {
            return DateTimeValue("yyyy-MM-dd HH:mm:ss");
        }

        public DateTime DateTimeValue(string format)
        {
            return DateTime.ParseExact(Value, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public decimal DecimalValue()
        {
            return decimal.Parse(Value);
        }

        public T EnumValue<T>()
        {
            return (T)Enum.Parse(typeof(T), Value);
        }

        public int IntValue()
        {
            return int.Parse(Value);
        }

        public long LongValue()
        {
            return long.Parse(Value);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            QueryParam qp = obj as QueryParam;
            if (qp == null)
            {
                return false;
            }
            return string.Equals(this.Name, qp.Name);
        }

        public override int GetHashCode()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return base.GetHashCode();
            }

            return this.Name.GetHashCode();
        }
    }
}
