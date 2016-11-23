using Dukou.SQ2.Dao;
using Dukou.SQ2.PO;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Dukou.SQ2.Service.Impl
{
    public class SQ2JobService : ISQ2JobService
    {
        private ConcurrentDictionary<string, bool> cache = new ConcurrentDictionary<string, bool>();

        public ISQ2JobDao SQ2JobDao { get; set; }

        public void ChangeMaster(string jobName, string ip, bool isMaster)
        {
            cache[$"{jobName}{ip}"] = isMaster;
        }

        public IList<SQ2Job> FindByJobName(string jobName)
        {
            return SQ2JobDao.FindByJobName(jobName);
        }


        public bool IsMaster(string jobName, string ip)
        {
            if (cache.TryGetValue($"{jobName}{ip}", out bool result))
            {
                return result;
            }
            return false;
        }

        [Transaction(ReadOnly = false)]
        public void Heartbeat(string jobName, string ip)
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
                sq2Job.ChangePriority();
                SQ2JobDao.Save(sq2Job);
            }
            else
            {
                if (sq2Job.UpdateTime.AddSeconds(15) < DateTime.Now)
                {
                    sq2Job.IsMaster = false;
                    sq2Job.ChangePriority();
                }
                sq2Job.UpdateTime = DateTime.Now;
                SQ2JobDao.Update(sq2Job);
            }
        }

        [Transaction(ReadOnly = false)]
        public bool RegisterMaster(string jobName, string ip)
        {
            var sq2Jobs = FindByJobName(jobName);
            if (sq2Jobs.FirstOrDefault(x => x.UpdateTime.AddSeconds(15) > DateTime.Now && x.IsMaster) == null)
            {
                var sq2Job = sq2Jobs
                    .Where(x => x.UpdateTime.AddSeconds(15) > DateTime.Now && !x.IsMaster)
                    .OrderBy(x => x.Priority)
                    .FirstOrDefault();

                if (sq2Job != null && string.Equals(ip, sq2Job.IP))
                {
                    sq2Job.IsMaster = true;
                    sq2Job.UpdateTime = DateTime.Now;
                    sq2Job.ChangePriority();

                    SQ2JobDao.Update(sq2Job);

                    return true;
                }
            }

            return false;
        }
    }
}
