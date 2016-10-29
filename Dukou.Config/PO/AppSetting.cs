using Dukou.SH4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Config.PO
{
    public class AppSetting : PO<string>
    {
        public virtual string Name { get; set; }

        public virtual string Value { get; set; }

        public virtual AppSettingType Type { get; set; }

    }
}
