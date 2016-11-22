using Dukou.SH4;

namespace Dukou.Config.PO
{
    public class AppSetting : PO<string>
    {
        public virtual string Name { get; set; }

        public virtual string Value { get; set; }

        public virtual AppSettingType Type { get; set; }

    }
}
