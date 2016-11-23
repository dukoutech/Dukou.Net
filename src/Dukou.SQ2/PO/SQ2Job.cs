using Dukou.SH4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SQ2.PO
{
    public class SQ2Job : PO<long>
    {
        public virtual string JobName { get; set; }

        public virtual string IP { get; set; }

        public virtual bool IsMaster { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
