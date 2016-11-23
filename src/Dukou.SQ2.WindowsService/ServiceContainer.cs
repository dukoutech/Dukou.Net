using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.WindowsService
{
    public class ServiceContainer
    {
        public ServiceBase[] ServicesToRun { get; set; }
    }
}
