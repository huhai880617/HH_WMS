
using HH.Application.ReceiptManage;
using HH.Code;
using HH.Domain.Entity.ReceiptManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HH.Web.Areas.ReceiptManage.Controllers
{
    public class ItemsDataController : ControllerBase
    {
        private ReceiptHeaderApp receiptHeaderApp = new ReceiptHeaderApp();
        private ReceiptDetailApp receiptDetailApp = new ReceiptDetailApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson( string keyword)
        {
            var data = receiptHeaderApp.GetList( keyword);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSelectJson(string enCode)
        {
            var data = receiptHeaderApp.GetItemList(enCode);
            List<object> list = new List<object>();
            foreach (ReceiptHeaderEntity item in data)
            {
                list.Add(new { id = item.F_ItemCode, text = item.F_ItemName });
            }
            return Content(list.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = receiptHeaderApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize(true, @"/ReceiptManage/ItemsData/Form")]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ReceiptHeaderEntity ReceiptHeaderEntity, string keyValue)
        {
            receiptHeaderApp.SubmitForm(ReceiptHeaderEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            ReceiptHeaderEntity headerEntity = receiptHeaderApp.GetForm(keyValue);
            receiptHeaderApp.Delete(headerEntity);
            return Success("删除成功。");
        }
    }
}
