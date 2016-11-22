using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SH4
{
    public abstract class PO<TId>
    {
        public virtual TId Id { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var tmp = obj as PO<TId>;
            if (tmp == null)
            {
                return false;
            }

            return Equals(Id, tmp.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
