using System;
using System.Globalization;

namespace Dukou.SH4.Query
{
    /// <summary>
    /// 查询参数
    /// </summary>
    public class QueryParam
    {
        public QueryParam(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// 获取参数值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetValue<T>()
        {
            return (T)Value;
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
