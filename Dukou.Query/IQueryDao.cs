using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Query
{
    public interface IQueryDao<TResult>
    {
        void Query(QueryContext<TResult> context);
    }
}
