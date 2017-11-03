
//------------------------------------------------------------------------------
// 
//     此代码由T4模板自动生成
//	   生成时间 2017-11-02 14:50:52 
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
namespace HH.Application.ReceiptManage
{
    /// <summary>
    /// ReceiptHeaderApp
    /// </summary>	
    public class ReceiptHeaderApp
    {
        private IReceiptHeaderRepository service = new ReceiptHeaderRepository();
        /// <summary>
        /// 获取所有头表数据
        /// </summary>
        /// <returns></returns>
        public List<ReceiptHeaderEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public ReceiptHeaderEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ReceiptHeaderEntity entity)
        {
            service.Delete(entity);
        }

        public void SubmitForm(ReceiptHeaderEntity entity, string keyValue)
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



