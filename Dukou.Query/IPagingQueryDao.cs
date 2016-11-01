using System.Collections.Generic;

namespace Dukou.Query
{
    public interface IPagingQueryDao<TResult>
    {
        void PagingQuery(PagingQueryContext<TResult> context);
    }
}
