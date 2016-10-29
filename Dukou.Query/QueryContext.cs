using System.Collections.Generic;

namespace Dukou.Query
{
    /// <summary>
    /// 查询上下文
    /// </summary>
    public class QueryContext<TResult>
    {
        public QueryContext()
        {
            Page = 1;
            PageSize = 20;
            OrderParams = new Dictionary<string, OrderParam>();
            QueryParams = new Dictionary<string, QueryParam>();
            QueryResult = new List<TResult>();
        }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public IDictionary<string, OrderParam> OrderParams { get; set; }

        public IDictionary<string, QueryParam> QueryParams { get; set; }

        public IList<TResult> QueryResult { get; set; }

    }
}
