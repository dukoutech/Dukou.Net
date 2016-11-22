using Dukou.Config.PO;
using Dukou.SH4;
using Dukou.SH4.Query;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace Dukou.Config.Dao.Impl
{
    public class AppSettingDao : HibernateDao<AppSetting, string>, IAppSettingDao
    {
        public void PagingQuery(PagingQueryContext<AppSetting> context)
        {
            context.QueryResult = HibernateTemplate.ExecuteFind((ISession session) =>
            {
                var criteria = session.CreateCriteria<AppSetting>("app");

                if (context.QueryParams.ContainsKey("Name"))
                {
                    criteria.Add(Restrictions.Eq("app.Name", context.GetQueryParam<string>("Name")));
                }

                if (context.QueryParams.ContainsKey("Type"))
                {
                    criteria.Add(Restrictions.Eq("app.Type", context.GetQueryParam<AppSettingType>("Type")));
                }

                if (context.QueryParams.ContainsKey("Ids"))
                {
                    criteria.Add(Restrictions.In("app.Id", context.GetQueryParam<string>("Ids").Split(',')));
                }

                context.TotalCount = criteria.SetProjection(Projections.Count("app.Id")).UniqueResult<int>();

                if (context.TotalCount == 0)
                {
                    return new List<AppSetting>();
                }

                criteria.SetProjection(new IProjection[] { null });
                criteria.SetResultTransformer(CriteriaSpecification.DistinctRootEntity);
                return criteria.SetFirstResult((context.Page - 1) * context.PageSize)
                        .SetMaxResults(context.PageSize)
                        .List<AppSetting>();
            });
        }
    }
}
