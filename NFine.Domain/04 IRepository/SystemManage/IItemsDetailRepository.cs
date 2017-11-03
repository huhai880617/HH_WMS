
using HH.Data;
using HH.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace HH.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
