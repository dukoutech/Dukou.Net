using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.WindowsService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            var container = Spring.Context.Support.ContextRegistry.GetContext().GetObject<ServiceContainer>();
            ServiceBase.Run(container.ServicesToRun);
        }
    }
}
