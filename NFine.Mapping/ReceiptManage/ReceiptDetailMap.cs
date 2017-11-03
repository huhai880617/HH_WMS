
//------------------------------------------------------------------------------
// 
//     此代码由T4模板自动生成
//	   生成时间 2017-11-02 14:56:09 
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//     
// 
//------------------------------------------------------------------------------
using HH.Domain.Entity.ReceiptManage;
using System.Data.Entity.ModelConfiguration;
namespace HH.Mapping.ReceiptManage
{
    /// <summary>
    /// ReceiptDetailMap
    /// </summary>	
    public class ReceiptDetailMap : EntityTypeConfiguration<ReceiptDetailEntity>
    {
        public ReceiptDetailMap()
        {
            this.ToTable("ReceiptDetail");
            this.HasKey(t => t.F_Id);
        }
    }
}



