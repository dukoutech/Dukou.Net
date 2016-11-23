namespace Dukou.SQ2.WindowsService
{
    partial class SQ2Service
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceInstaller = new System.ServiceProcess.ServiceInstaller();
            this.serviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            // 
            // serviceProcessInstaller
            // 
            this.serviceProcessInstaller.Password = serviceInstallerConfig?.Password;
            this.serviceProcessInstaller.Username = serviceInstallerConfig?.Username;
            this.serviceProcessInstaller.Account = serviceInstallerConfig == null ? System.ServiceProcess.ServiceAccount.LocalSystem : serviceInstallerConfig.Account;
            // 
            // SQ2Service
            // 
            this.ServiceName = serviceInstallerConfig == null ? "Dukou SQ2Service" : serviceInstallerConfig.ServiceName;
        }

        #endregion

        private System.ServiceProcess.ServiceInstaller serviceInstaller;
        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller;
    }
}
