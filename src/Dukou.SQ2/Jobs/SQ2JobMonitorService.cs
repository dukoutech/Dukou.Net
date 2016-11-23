using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Dukou.SQ2.Service;

namespace Dukou.SQ2.Jobs
{
    public class SQ2JobMonitorService : IJobService
    {
        public IList<string> JobNames { get; set; }

        public ISQ2JobService SQ2JobService { get; set; }

        public void Execute(IJobExecutionContext context, AbstractQuartzJobObject job)
        {
            string ip = GetIP6OrIP4();
            foreach (var jobName in JobNames)
            {
                SQ2JobService.Heartbeat(jobName, ip);
                SQ2JobService.ChangeMaster(jobName, ip, SQ2JobService.RegisterMaster(jobName, ip));
            }
        }

        /// <summary>
        /// 获取IP6或者IP4地址
        /// </summary>
        /// <returns></returns>
        private string GetIP6OrIP4()
        {
            var addresses = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());

            var address = addresses.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6);
            if (address == null)
            {
                address = addresses.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            }
            return address.ToString();
        }
    }
}
