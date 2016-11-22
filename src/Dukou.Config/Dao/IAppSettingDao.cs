using Dukou.Config.PO;
using Dukou.SH4;
using Dukou.SH4.Query;

namespace Dukou.Config.Dao
{
    public interface IAppSettingDao : IHibernateDao<AppSetting, string>, IPagingQueryDao<AppSetting>
    {

    }
}
