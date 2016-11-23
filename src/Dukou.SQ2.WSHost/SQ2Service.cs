using Common.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dukou.SQ2.WSHost
{
    public partial class SQ2Service : ServiceBase
    {
        private static ILog logger = LogManager.GetLogger<SQ2Service>();

        private ServiceInstallerConfig serviceInstallerConfig = null;

        public IList<IScheduler> Schedulers { get; set; }

        public SQ2Service()
        {
            this.serviceInstallerConfig = Spring.Context.Support.ContextRegistry.GetContext().GetObject<ServiceInstallerConfig>();

            InitializeComponent();
        }

        public SQ2Service(ServiceInstallerConfig config)
        {
            this.serviceInstallerConfig = config;

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                foreach (var item in Schedulers)
                {
                    if (item.IsShutdown)
                    {
                        item.Start();
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            logger.Info($"====  {ServiceName}已启动  =====");
        }

        protected override void OnStop()
        {
            try
            {
                foreach (var item in Schedulers)
                {
                    item.Shutdown();
                }

                Thread.Sleep(1000);

                Spring.Context.Support.ContextRegistry.GetContext().Dispose();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            logger.Info($"====  {ServiceName}已关闭  ====");
        }
    }
}
