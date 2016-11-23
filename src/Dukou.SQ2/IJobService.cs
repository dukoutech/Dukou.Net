using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2
{
    public interface IJobService
    {
        void Execute(IJobExecutionContext context, AbstractQuartzJobObject job);
    }
}
