using Dukou.Config.PO;
using Dukou.Query;
using Dukou.SH4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Config.Dao.Impl
{
    public class AppSettingDao : HibernateDao<AppSetting, string>, IAppSettingDao
    {
        public IList<AppSetting> SelectByPage(QueryContext<AppSetting> query)
        {
            throw new NotImplementedException();
        }
    }
}
