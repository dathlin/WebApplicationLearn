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
    public class CraneController : Controller
    {
        private MachineEntities db = new MachineEntities();

        // GET: Crane
        [HttpPost]
        public async Task<ActionResult> Index()
        {
            return PartialView(await db.起重设备台帐.ToListAsync());
        }

        //获取J送数据
        [HttpPost]
        public async Task<ActionResult> GetCraneData(FormCollection fc)
        {
            //int page = Convert.ToInt32(fc["page"]);
            //int rows = Convert.ToInt32(fc["rows"]);
            //string itemid = fc["itemid"];
            //string productid = fc["productid"];

            //int offect = (page - 1) * rows;

            List<起重设备台帐> datas = await db.起重设备台帐.ToListAsync();

            //Newtonsoft.Json.Linq.JObject json = new Newtonsoft.Json.Linq.JObject();
            //json.Add("total", new Newtonsoft.Json.Linq.JValue(datas.Count));

            //if (!string.IsNullOrEmpty(itemid))
            //{
            //    datas = (from d in datas
            //             where d.设备名称.Contains(itemid)
            //             select d).ToList();
            //}
            //if (!string.IsNullOrEmpty(productid))
            //{
            //    datas = (from d in datas
            //             where d.注册代码.Contains(productid)
            //             select d).ToList();
            //}

            
            //List<起重设备台帐> result = new List<起重设备台帐>();
            //for (int i = 0; i < datas.Count; i++)
            //{
            //    if (i >= offect && i < offect + rows)
            //    {
            //        result.Add(datas[i]);
            //    }
            //}
            //json.Add("rows", new Newtonsoft.Json.Linq.JValue(Newtonsoft.Json.Linq.JArray.FromObject(datas).ToString()));
            return Content(Newtonsoft.Json.Linq.JArray.FromObject(datas).ToString());
        }
        // GET: Crane/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            起重设备台帐 起重设备台帐 = await db.起重设备台帐.FindAsync(id);
            if (起重设备台帐 == null)
            {
                return HttpNotFound();
            }
            return View(起重设备台帐);
        }

        // GET: Crane/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crane/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "序号,本次检验日期,下次检验日期,是否已检,资料移交,移交日期,注册代码,设备状态,设备等级,内部编号,原,检,登,所属分厂,设备使用地点,安装单位,设备名称,规格型号,设备制造单位,产品编号,电动葫芦产品编号,出厂日期,始用时间,备注")] 起重设备台帐 起重设备台帐)
        {
            if (ModelState.IsValid)
            {
                db.起重设备台帐.Add(起重设备台帐);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(起重设备台帐);
        }

        // GET: Crane/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            起重设备台帐 起重设备台帐 = await db.起重设备台帐.FindAsync(id);
            if (起重设备台帐 == null)
            {
                return HttpNotFound();
            }
            return View(起重设备台帐);
        }

        // POST: Crane/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "序号,本次检验日期,下次检验日期,是否已检,资料移交,移交日期,注册代码,设备状态,设备等级,内部编号,原,检,登,所属分厂,设备使用地点,安装单位,设备名称,规格型号,设备制造单位,产品编号,电动葫芦产品编号,出厂日期,始用时间,备注")] 起重设备台帐 起重设备台帐)
        {
            if (ModelState.IsValid)
            {
                db.Entry(起重设备台帐).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(起重设备台帐);
        }

        // GET: Crane/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            起重设备台帐 起重设备台帐 = await db.起重设备台帐.FindAsync(id);
            if (起重设备台帐 == null)
            {
                return HttpNotFound();
            }
            return View(起重设备台帐);
        }

        // POST: Crane/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            起重设备台帐 起重设备台帐 = await db.起重设备台帐.FindAsync(id);
            db.起重设备台帐.Remove(起重设备台帐);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        
        public async Task<ActionResult> Crane()
        {
            return PartialView(await db.起重设备台帐.ToListAsync());
        }
    }
}
