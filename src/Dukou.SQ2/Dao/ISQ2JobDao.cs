using Dukou.SH4;
using Dukou.SQ2.PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.Dao
{
    public interface ISQ2JobDao : IHibernateDao<SQ2Job, long>
    {
        IList<SQ2Job> FindByJobName(string jobName);

        SQ2Job FindByJobNameAndIP(string jobName, string ip);
    }
}
