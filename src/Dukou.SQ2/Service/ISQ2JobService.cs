using Dukou.SQ2.PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.Service
{
    public interface ISQ2JobService
    {
        /// <summary>
        /// 改变主机
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="ip"></param>
        /// <param name="isMaster"></param>
        void ChangeMaster(string jobName, string ip, bool isMaster);

        /// <summary>
        /// 通过JobName获取SQ2Job
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        IList<SQ2Job> FindByJobName(string jobName);

        /// <summary>
        /// 是否主机
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        bool IsMaster(string jobName, string ip);

        /// <summary>
        /// 心跳检测
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="ip"></param>
        void Heartbeat(string jobName, string ip);

        /// <summary>
        /// 注册主机
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        bool RegisterMaster(string jobName, string ip);
    }
}
