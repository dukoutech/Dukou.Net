using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Dukou.SQ2.Dao;
using Spring.Transaction.Interceptor;

namespace Dukou.SQ2.Jobs
{
    public class SQ2JobMonitorService : IJobService
    {
        public IList<string> JobNames { get; set; }

        public ISQ2JobDao SQ2JobDao { get; set; }

        [Transaction(ReadOnly = false)]
        public void Execute(IJobExecutionContext context, AbstractQuartzJobObject job)
        {
            string ip = GetIP6OrIP4();
            foreach (var jobName in JobNames)
            {
                var sq2Job = SQ2JobDao.FindByJobNameAndIP(jobName, ip);
                if (sq2Job == null)
                {
                    sq2Job = new PO.SQ2Job()
                    {
                        IP = ip,
                        IsMaster = false,
                        JobName = jobName,
                        UpdateTime = DateTime.Now
                    };
                    SQ2JobDao.Save(sq2Job);
                }
                else
                {
                    sq2Job.UpdateTime = DateTime.Now;
                    SQ2JobDao.Update(sq2Job);
                }
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
