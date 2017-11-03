

//------------------------------------------------------------------------------
// 
//     此代码由T4模板自动生成
//	   生成时间 2017-11-02 14:54:52 
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//     
// 
//------------------------------------------------------------------------------

using System;
namespace HH.Domain.Entity.ReceiptManage
{
    /// <summary>
    /// ReceiptDetailEntity
    /// </summary>	
    public class ReceiptDetailEntity : IEntity<ReceiptDetailEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string F_ParentId { get; set; }
        public string F_ItemCode { get; set; }
        public string F_ItemName { get; set; }
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
        public string F_ItemBatch { get; set; }
        public string F_CommanyCode { get; set; }
        public string F_WarehouseCode { get; set; }
        public string F_ReceiptCode { get; set; }
        public string F_ReceiptId { get; set; }
        public int? F_TotalQty { get; set; }
        public int? F_Status { get; set; }
        public int? F_FinishQty { get; set; }
        public int? F_HandQty { get; set; }
    }
}



