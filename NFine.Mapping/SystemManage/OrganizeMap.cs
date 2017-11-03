
using HH.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace HH.Mapping.SystemManage
{
    public class OrganizeMap : EntityTypeConfiguration<OrganizeEntity>
    {
        public OrganizeMap()
        {
            this.ToTable("Sys_Organize");
            this.HasKey(t => t.F_Id);
        }
    }
}
