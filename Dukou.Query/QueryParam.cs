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
