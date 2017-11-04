
//------------------------------------------------------------------------------
// 
//     此代码由T4模板自动生成
//	   生成时间 2017-11-02 15:00:28 
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//     
// 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HH.Domain.Entity.ReceiptManage;
using HH.Domain.IRepository.ReceiptManage;
using HH.Repository.ReceiptManage;
using System.Linq.Expressions;

namespace HH.Application.ReceiptManage
{
    /// <summary>
    /// ReceiptDetailApp
    /// </summary>	
    public class ReceiptDetailApp
    {
        private IReceiptDetailRepository service = new ReceiptDetailRepository();

        /// <summary>
        /// 根据头表的主键标识 查询明细信息
        /// </summary>
        /// <param name="headerId"></param>
        /// <returns></returns>
        public List<ReceiptDetailEntity> GetList(string headerId)
        {
            Expression<Func<ReceiptDetailEntity, bool>> predicate = t => t.F_ReceiptId == headerId;
            return service.IQueryable(predicate).ToList();
        }

        public ReceiptDetailEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ReceiptDetailEntity entity)
        {
            service.Delete(entity);
        }
        
        public void SubmitForm(ReceiptDetailEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }

    }
}



