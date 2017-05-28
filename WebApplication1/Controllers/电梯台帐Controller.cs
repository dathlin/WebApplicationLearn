using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class 电梯台帐Controller : Controller
    {
        private MachineEntities db = new MachineEntities();

        [HttpPost]
        // GET: 电梯台帐
        public async Task<ActionResult> Index()
        {
            return PartialView(await db.电梯台帐.ToListAsync());
        }

        public ActionResult Elevators()
        {
            return View("Elevators");
        }


        // GET: 电梯台帐/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            电梯台帐 电梯台帐 = await db.电梯台帐.FindAsync(id);
            if (电梯台帐 == null)
            {
                return HttpNotFound();
            }
            return View(电梯台帐);
        }

        // GET: 电梯台帐/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 电梯台帐/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "序号,本次检验日期,下次检验日期,是否已检,设备代码,设备状态,设备等级,内部编号,安全管理人员,是否移交,移交日期,原,检,登,所属分厂,属地部门,设备名称,设备型号,设备制造单位,产品编号,出厂日期,始用时间,固定资产编号,维修次数")] 电梯台帐 电梯台帐)
        {
            if (ModelState.IsValid)
            {
                db.电梯台帐.Add(电梯台帐);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(电梯台帐);
        }

        // GET: 电梯台帐/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            电梯台帐 电梯台帐 = await db.电梯台帐.FindAsync(id);
            if (电梯台帐 == null)
            {
                return HttpNotFound();
            }
            return View(电梯台帐);
        }

        // POST: 电梯台帐/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "序号,本次检验日期,下次检验日期,是否已检,设备代码,设备状态,设备等级,内部编号,安全管理人员,是否移交,移交日期,原,检,登,所属分厂,属地部门,设备名称,设备型号,设备制造单位,产品编号,出厂日期,始用时间,固定资产编号,维修次数")] 电梯台帐 电梯台帐)
        {
            if (ModelState.IsValid)
            {
                db.Entry(电梯台帐).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(电梯台帐);
        }

        // GET: 电梯台帐/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            电梯台帐 电梯台帐 = await db.电梯台帐.FindAsync(id);
            if (电梯台帐 == null)
            {
                return HttpNotFound();
            }
            return View(电梯台帐);
        }

        // POST: 电梯台帐/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            电梯台帐 电梯台帐 = await db.电梯台帐.FindAsync(id);
            db.电梯台帐.Remove(电梯台帐);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
