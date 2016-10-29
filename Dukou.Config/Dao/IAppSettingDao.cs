using Dukou.Config.PO;
using Dukou.Query;
using Dukou.SH4;

namespace Dukou.Config.Dao
{
    public interface IAppSettingDao : IHibernateDao<AppSetting, string>, IPagingQueryDao<AppSetting>
    {

    }
}
