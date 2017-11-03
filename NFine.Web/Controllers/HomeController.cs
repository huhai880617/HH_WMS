/*******************************************************************************
 * Copyright © 2016 HH.Framework 版权所有
 * Author: HH
 * Description: HH快速开发平台
 * Website：http://www.HH.cn
*********************************************************************************/
using HH.Application.SystemManage;
using HH.Code;
using HH.Domain.Entity.SystemManage;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace HH.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
    }
}
