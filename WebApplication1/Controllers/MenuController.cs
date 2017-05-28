using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        /****************************************************************************************
         * 
         *    所有菜单的反应
         * 
         * 
         * 
         * 
         ***************************************************************************************/

        private MachineEntities db = new MachineEntities();

        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Elevator()
        {
            return PartialView();
        }


        /// <summary>
        /// 退出信息时清理资源
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}