using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Areas.Yonetim.Controllers
{
    //public class KategorilerController : Controller
    //{
    //    // GET: Yonetim/Kategoriler
    //    public ActionResult Index()
    //    {
    //        using (ProjectEntitie db = new ProjectEntitie())
    //        {
    //            int kuid = Convert.ToInt32(Session["kuid"]);
    //            if (kuid != 0)
    //            {
    //                var kategoriler = MobilyaVM.ToList();
    //                kategoriler.KategoriList = db.Products.Where(x => x.IsActive == true).ToList();
    //                return View(kategoriler);
    //            }
    //            else
    //            {
    //                return Redirect("/Yonetim/Index");
    //            }
    //        }
    //    }
    //    public ActionResult Duzenle(int id,string ad)
    //     {
    //        using (ProjectEntitie db = new ProjectEntitie())
    //        {
    //            int kuid = Convert.ToInt32(Session["kuid"]);
    //            if (kuid != 0)
    //            {
    //                var kategoriler = db.TBL_Kategoriler.SingleOrDefault(x => x.Id == id);
    //                kategoriler.Ad = ad;
    //                db.SaveChanges();
    //                return Redirect("/Yonetim/Kategoriler/Index");
    //            }
    //            else
    //            {
    //                return Redirect("/Yonetim/Index");
    //            }
    //        }
    //    }
    //    public ActionResult Sil(int id)
    //    {
    //        using (ProjectEntitie db = new ProjectEntitie())
    //        {
    //            int kuid = Convert.ToInt32(Session["kuid"]);
    //            if (kuid != 0)
    //            {
    //                var silinecek = db.TBL_Kategoriler.SingleOrDefault(x => x.Id == id);
    //                silinecek.AktifMi = false;
    //                var mobilyalar = db.TBL_Mobilyalar.Where(x => x.KategoriId == id).ToList();
    //                mobilyalar.ForEach(x => x.AktifMi = false);
    //                db.SaveChanges();
    //                return Redirect("/Yonetim/Kategoriler/Index");
    //            }
    //            else
    //            {
    //                return Redirect("/Yonetim/Index");
    //            }
    //        }
    //    }
    //}
}