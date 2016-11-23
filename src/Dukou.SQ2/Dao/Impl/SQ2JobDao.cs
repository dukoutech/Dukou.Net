using Dukou.SH4;
using Dukou.SQ2.PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.Dao.Impl
{
    public class SQ2JobDao : HibernateDao<SQ2Job, long>, ISQ2JobDao
    {
        public IList<SQ2Job> FindByJobName(string jobName)
        {
            throw new NotImplementedException();
        }

        public SQ2Job FindByJobNameAndIP(string jobName, string ip)
        {
            throw new NotImplementedException();
        }
    }
}
