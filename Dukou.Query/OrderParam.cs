namespace Dukou.Query
{
    /// <summary>
    /// 排序参数
    /// </summary>
    public class OrderParam
    {
        public OrderParam() { }

        public OrderParam(string name, bool ascending)
        {
            this.Name = name;
            this.Ascending = ascending;
        }

        /// <summary>
        /// 排序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否升序
        /// </summary>
        public bool Ascending { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            OrderParam op = obj as OrderParam;
            if (op == null)
            {
                return false;
            }
            return string.Equals(this.Name, op.Name);
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
