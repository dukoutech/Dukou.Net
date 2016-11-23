using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2
{
    /// <summary>
    /// 限制并发执行
    /// </summary>
    [DisallowConcurrentExecution]
    public class DisallowConcurrentExecutionQuartzJobObject : AbstractQuartzJobObject
    {

    }
}
