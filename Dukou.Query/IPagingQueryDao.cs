using System.Collections.Generic;

namespace Dukou.Query
{
    public interface IPagingQueryDao<TResult>
    {
        void SelectByPage(QueryContext<TResult> context);
    }
}
