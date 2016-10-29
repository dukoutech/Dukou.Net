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
            QueryParams = new List<QueryParam>();
            QueryResult = new List<TResult>();
            OrderParams = new List<OrderParam>();
        }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public IList<QueryParam> QueryParams { get; set; }

        public IList<TResult> QueryResult { get; set; }

        public IList<OrderParam> OrderParams { get; set; }


    }
}
