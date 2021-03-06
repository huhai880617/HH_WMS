﻿
using HH.Data;
using HH.Domain.Entity.SystemManage;
using HH.Domain.IRepository.SystemManage;
using HH.Repository.SystemManage;
using System.Collections.Generic;

namespace HH.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
