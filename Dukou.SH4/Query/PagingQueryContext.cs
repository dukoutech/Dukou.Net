using System.Collections.Generic;

namespace Dukou.SH4.Query
{
    /// <summary>
    /// 分页查询上下文
    /// </summary>
    public class PagingQueryContext<TResult> : QueryContext<TResult>
    {
        public PagingQueryContext() : base()
        {
            Page = 1;
            PageSize = 20;
        }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

    }
}
