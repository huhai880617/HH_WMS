
using HH.Data;
using HH.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace HH.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}
