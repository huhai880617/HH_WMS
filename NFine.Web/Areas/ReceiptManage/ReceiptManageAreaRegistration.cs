using System.Web.Mvc;

namespace HH.Web.Areas.ReceiptManage
{
    public class ReceiptManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ReceiptManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
              this.AreaName + "_Default",
              this.AreaName + "/{controller}/{action}/{id}",
              new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
              new string[] { "HH.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
