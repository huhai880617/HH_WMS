using HH.Data.Extensions;
using HH.Application.ReceiptManage;
using HH.Code;
using HH.Domain.Entity.ReceiptManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Linq.Expressions;
using System;

namespace HH.Web.Areas.ReceiptManage.Controllers
{
    public class ReceiptHeaderController : ControllerBase
    {
        private ReceiptHeaderApp receiptHeaderApp = new ReceiptHeaderApp();
        private ReceiptDetailApp receiptDetailApp = new ReceiptDetailApp();

        /// <summary>
        /// 根据查询条件获取头表信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDetailGridJson()
        {
            
            var data = receiptHeaderApp.GetList();
            return Content(data.ToJson());
        }
        /// <summary>
        /// 根据头表的主键 查询明细表数据
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDetailGridJson( string keyword)
        {
            var data = receiptDetailApp.GetList(keyword);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSelectJson(string enCode)
        {
           // var data = receiptHeaderApp.GetItemList(enCode);
            List<object> list = new List<object>();
            //foreach (ReceiptHeaderEntity item in data)
            //{
            //    list.Add(new { id = item.F_ItemCode, text = item.F_ItemName });
            //}
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



        /// <summary>
        /// 构建查询表达式
        /// </summary>
        /// <returns></returns>
        private Expression<Func<ReceiptHeaderEntity, Boolean>> BuildSearchCriteria()
        {
            DynamicLambda<ReceiptHeaderEntity> bulider = new DynamicLambda<ReceiptHeaderEntity>();
            Expression<Func<ReceiptHeaderEntity, Boolean>> expr = null;

            if (!string.IsNullOrEmpty(Request["F_Code"]))
            {
                var data = Request["F_Code"].Trim();
                Expression<Func<ReceiptHeaderEntity, Boolean>> tmp = t => t.F_Code.Contains(data);
                expr = bulider.BuildQueryAnd(expr, tmp);
            }

            Expression<Func<ReceiptHeaderEntity, Boolean>> tmpSolid = t => t.F_DeleteMark == false;
            expr = bulider.BuildQueryAnd(expr, tmpSolid);

            return expr;
        }
    }
}
