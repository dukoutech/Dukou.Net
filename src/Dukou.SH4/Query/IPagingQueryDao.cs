using System.Collections.Generic;

namespace Dukou.SH4.Query
{
    public interface IPagingQueryDao<TResult>
    {
        void PagingQuery(PagingQueryContext<TResult> context);
    }
}
