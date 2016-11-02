using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SH4.Query
{
    /// <summary>
    /// 查询上下文
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class QueryContext<TResult>
    {
        public QueryContext()
        {
            OrderParams = new Dictionary<string, OrderParam>();
            QueryParams = new Dictionary<string, QueryParam>();
            QueryResult = new List<TResult>();
        }

        public IDictionary<string, OrderParam> OrderParams { get; private set; }

        public IDictionary<string, QueryParam> QueryParams { get; private set; }

        public IList<TResult> QueryResult { get; set; }

        public bool GetOrderParam(string name)
        {
            return OrderParams[name].Ascending;
        }

        public void SetOrderParam(string name, bool ascending)
        {
            OrderParams[name] = new OrderParam(name, ascending);
        }

        public T GetQueryParam<T>(string name)
        {
            return QueryParams[name].GetValue<T>();
        }

        public void SetQueryParam(string name, object value)
        {
            QueryParams[name] = new QueryParam(name, value);
        }
    }
}
