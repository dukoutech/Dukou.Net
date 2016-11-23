using Spring.Scheduling.Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace Dukou.SQ2
{
    /// <summary>
    /// 
    /// </summary>
    public class AbstractQuartzJobObject : QuartzJobObject
    {
        /// <summary>
        /// Job名称
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// Job服务
        /// </summary>
        public IJobService JobService { get; set; }

        protected override void ExecuteInternal(IJobExecutionContext context)
        {
            JobService.Execute(context, this);
        }
    }
}
