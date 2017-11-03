

//------------------------------------------------------------------------------
// 
//     此代码由T4模板自动生成
//	   生成时间 2017-11-02 14:38:59 
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//     
// 
//------------------------------------------------------------------------------

using System;
namespace HH.Domain.Entity.ReceiptManage
{
    /// <summary>
    /// ReceiptHeaderEntity
    /// </summary>	
    public class ReceiptHeaderEntity : IEntity<ReceiptHeaderEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string F_ParentId { get; set; }
        public string F_Code { get; set; }
        public string F_Name { get; set; }
        public bool? F_IsTree { get; set; }
        public int? F_Layers { get; set; }
        public int? F_SortCode { get; set; }
        public bool? F_DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
        public string F_Batch { get; set; }
        public string F_CommanyCode { get; set; }
        public string F_WarehouseCode { get; set; }
        public string F_LinkCode { get; set; }
        public string F_ReceiptType { get; set; }
        public string F_WaveId { get; set; }
        public string F_Status { get; set; }
    }
}



