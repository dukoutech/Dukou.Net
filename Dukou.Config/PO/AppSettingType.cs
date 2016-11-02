using System.ComponentModel;

namespace Dukou.Config.PO
{
    /// <summary>
    /// 应用设置类型
    /// </summary>
    public enum AppSettingType
    {
        /// <summary>
        /// 系统
        /// </summary>
        [Description("系统")]
        System = 1,

        /// <summary>
        /// 业务
        /// </summary>
        [Description("业务")]
        Biz = 2
    }
}
