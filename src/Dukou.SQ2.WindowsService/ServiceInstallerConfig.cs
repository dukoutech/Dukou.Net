using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.WindowsService
{
    public class ServiceInstallerConfig
    {
        public ServiceAccount Account { get; set; }

        public string ServiceName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
