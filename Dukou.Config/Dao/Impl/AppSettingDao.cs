using Dukou.Config.PO;
using Dukou.Query;
using Dukou.SH4;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Config.Dao.Impl
{
    public class AppSettingDao : HibernateDao<AppSetting, string>, IAppSettingDao
    {
        public void SelectByPage(QueryContext<AppSetting> context)
        {
            context.QueryResult = HibernateTemplate.ExecuteFind<AppSetting>((ISession session) => 
            {
                var criteria = session.CreateCriteria<AppSetting>("app");

                if (context.QueryParams.ContainsKey("Name"))
                {
                    criteria.Add(Restrictions.Eq("app.Name", context.QueryParams["Name"].Value));
                }

                if (context.QueryParams.ContainsKey("Type"))
                {
                    criteria.Add(Restrictions.Eq("app.Type", context.QueryParams["Type"].EnumValue<AppSettingType>()));
                }

                if (context.QueryParams.ContainsKey("Ids"))
                {
                    criteria.Add(Restrictions.In("app.Id", context.QueryParams["Ids"].Value.Split(',')));
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
