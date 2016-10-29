using System.Collections.Generic;

namespace Dukou.Query
{
    public interface IPagingQueryDao<TResult>
    {
        IList<TResult> SelectByPage(QueryContext<TResult> query);
    }
}
