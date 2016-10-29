using NHibernate;
using Spring.Data.NHibernate.Generic.Support;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SH4
{
    public class HibernateDao<PO, TId> : HibernateDaoSupport, IHibernateDao<PO, TId> where PO : PO<TId>
    {
        public PO FindById(TId id)
        {
            return this.HibernateTemplate.Get<PO>(id);
        }

        public IList<PO> SelectAll()
        {
            return this.HibernateTemplate.LoadAll<PO>();
        }

        [Transaction(ReadOnly = false)]
        public TId Save(PO po)
        {
            po.Id = (TId)this.HibernateTemplate.Save(po);

            return po.Id;
        }

        [Transaction(ReadOnly = false)]
        public void Update(PO po)
        {
            this.HibernateTemplate.Update(po);
        }

        [Transaction(ReadOnly = false)]
        public void SaveOrUpdate(PO po)
        {
            this.HibernateTemplate.SaveOrUpdate(po);
        }

        [Transaction(ReadOnly = false)]
        public void SaveOrUpdate(IList<PO> entities)
        {
            this.HibernateTemplate.Execute<int>((ISession session) =>
            {
                foreach (var item in entities)
                {
                    session.SaveOrUpdate(item);
                }
                return 0;
            });
        }

        [Transaction(ReadOnly = false)]
        public void Delete(PO po)
        {
            this.HibernateTemplate.Delete(po);
        }

        public void Refresh(PO po)
        {
            this.HibernateTemplate.Refresh(po);
        }

        public void Evict(PO po)
        {
            this.HibernateTemplate.Evict(po);
        }

        public void Lock(PO po)
        {
            this.HibernateTemplate.Lock(po, LockMode.None);
        }

        public void Lock(PO po, LockMode lockMode)
        {
            this.HibernateTemplate.Lock(po, lockMode);
        }

        public void Flush()
        {
            this.HibernateTemplate.Flush();
        }

        public void Clear()
        {
            this.HibernateTemplate.Clear();
        }
    }
}
