using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.SH4
{
    public interface IHibernateDao<PO, TId> where PO : PO<TId>
    {
        /// <summary>
        /// 根据 ID 查找持久对象。找不到则返回 null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PO FindById(TId id);

        /// <summary>
        /// 查找所有持久对象
        /// </summary>
        /// <returns></returns>
        IList<PO> SelectAll();

        /// <summary>
        /// 保存指定的持久对象
        /// </summary>
        /// <param name="po"></param>
        /// <returns></returns>
        TId Save(PO po);

        /// <summary>
        /// 更新指定的持久对象
        /// </summary>
        /// <param name="po"></param>
        void Update(PO po);

        /// <summary>
        /// 保存或更新指定的持久对象
        /// </summary>
        /// <param name="po"></param>
        void SaveOrUpdate(PO po);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="po"></param>
        void SaveOrUpdate(IList<PO> po);

        /// <summary>
        /// 删除指定的持久对象
        /// </summary>
        /// <param name="po"></param>
        void Delete(PO po);

        /// <summary>
        /// 刷新持久对象（即从数据库中重新获取相应值）
        /// </summary>
        /// <param name="po"></param>
        void Refresh(PO po);

        /// <summary>
        /// 将持久对象从会话缓存中移除
        /// </summary>
        /// <param name="po"></param>
        void Evict(PO po);

        /// <summary>
        /// 将持久对象与会话重新关联
        /// </summary>
        /// <param name="po"></param>
        void Lock(PO po);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lockMode"></param>
        void Lock(PO po, LockMode lockMode);

        /// <summary>
        /// 将当前挂起的各项操作（save、update、delete）刷新到数据库中
        /// </summary>
        void Flush();

        /// <summary>
        /// 清除当前会话缓存中的所有数据，取消挂起的各项操作（save、update、delete）
        /// </summary>
        void Clear();
    }
}
