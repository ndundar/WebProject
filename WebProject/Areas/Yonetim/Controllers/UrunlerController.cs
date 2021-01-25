//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebProject.Areas.Yonetim.Controllers;

//namespace WebProject.Areas.Yonetim.Controllers
//{
//    public class UrunlerController : Controller
//    {
//        public object ProjectVM { get; private set; }

//        // GET: Yonetim/Urunler
//        public ActionResult Index()
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if (kuid != 0)
//                {
//                    var urun = ProjectVM.ToString();
//                    //urun. = db.Products.Where(x => x.i == true).ToList();
//                    return View(urun);

//                }
//                else
//                {
//                    return Redirect("/Yonetim/Index");

//                }
            
//            }*/
//            return View();
//        }
//        [HttpGet]
//        public ActionResult Ekle()
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if (kuid != 0)
//                {
//                    return View();
//                }
//                else
//                {
//                    return Redirect("/Yonetim/Index");
//                }
//            }*/
//            return View();
//        }
//        [HttpPost]
//        //public ActionResult Ekle(ProjectVM PVM, HttpPostedFileBase[] Fotograflar, string[] ozellik)
//        //{
//        //    using (ProjectEntitie db = new ProjectEntitie())
//        //    {
//        //        int kuid = Convert.ToInt32(Session["kuid"]);
//        //        if (kuid != 0)
//        //        {
//        //            PVM.Photo.IsActive = true;
//        //            PVM.Product.AddedaAte = DateTime.Now;
//        //            db.Products.Add(PVM.Product);
//        //            db.SaveChanges();
//        //            int i = 0;
//        //            foreach (var file in Fotograflar)
//        //            {
//        //                Bitmap Resim = new Bitmap(file.InputStream);
//        //                Resim.Save(Server.MapPath("~/Content/img/product/" + file.FileName));
//        //                Resim.Dispose();
//        //                Product pdt = new Product();
//        //                pdt.IsActive = true;
//        //                pdt.Photo = file.FileName;
//        //                pdt.Id = PVM.Product.Id;
//        //                PVM.Product.Photo = file.FileName;
//        //                db.Products.Add(pdt);

//        //            }
//        //            foreach (var item in db.Products.ToList())
//        //            {
//        //                Product o = new Product();
//        //                o.Id = PVM.Product.Id;
//        //                db.Products.Add(o);
//        //                i++;
//        //            }
//        //            db.SaveChanges();

//        //            return Redirect("/Yonetim/Urunler/Index");

//        //        }
//        //        else
//        //        {
//        //            return Redirect("/Yonetim/Index");
//        //        }
//        //    }
//        //}
//        public ActionResult Duzenle(int id)
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if (kuid != 0)
//                {
//                    var urun = ProjectVM.ToString();
//                    //urun. = db.Products.SingleOrDefault(x => x.Id == id);
//                    return View(urun);

//                }
//                else
//                {
//                    return Redirect("/Yonetim/Index");

//                }
//            }*/
//            return View();
//        }
//        [HttpPost]
//        //public ActionResult Duzenle(ProjectVM PVM, HttpPostedFileBase[] Fotograflar, string[] ozellik)
//        //{
//        //    using (ProjectEntitie db = new ProjectEntitie())
//        //    {
//        //        int kuid = Convert.ToInt32(Session["kuid"]);
//        //        if (kuid != 0)
//        //        {
//        //            var urun = db.Products.SingleOrDefault(x => x.Id == PVM.Product.Id);
//        //            urun.ProductName = PVM.Product.ProductName;
//        //            urun.Price = PVM.Product.Price;
//        //            urun.Explanation = PVM.Product.Explanation;
//        //            urun.AddedDate = DateTime.Now;
//        //            urun.IsActive = true;
//        //            int i = 0;
//        //            db.SaveChanges();
//        //            if (Fotograflar[0] != null)
//        //            {
//        //                foreach (HttpPostedFileBase file in Fotograflar)
//        //                {
//        //                    Bitmap Resim = new Bitmap(file.InputStream);
//        //                    Resim.Save(Server.MapPath("~/Content/img/product/" + file.FileName));
//        //                    Resim.Dispose();
//        //                    Product mf = new Product();
//        //                    mf.IsActive = true;
//        //                    mf.Id = urun.Id;
//        //                    mf.Photo = file.FileName;
//        //                    db.Products.Add(mf);
//        //                }
//        //            }

               
//        //            db.SaveChanges();
//        //            return Redirect("/Yonetim/Urunler/Index");

//        //        }
//        //        else
//        //        {
//        //            return Redirect("/Yonetim/Index");

//        //        }
//        //    }
//        //}
//        public ActionResult Sil(int id)
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if (kuid != 0)
//                {
//                    var silinecek = db.Products.SingleOrDefault(x => x.Id == id);
//                    silinecek.IsActive = false;
//                    db.SaveChanges();
//                    return Redirect("/Yonetim/Urunler/Index");
//                }
//                else
//                {
//                    return Redirect("/Yonetim/Index");
//                }
//            }*/
//            return View();
//        }
//        public ActionResult OnFotograf(int id)
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if(kuid!=0)
//                {
//                    var photo = db.Products.Where(x => x.Id == id).ToList();
//                    List<Product> fotoList = new List<Product>();
//                    foreach (var item in photo)
//                    {
//                        Product mf = new Product();
//                        mf.Photo = item.Photo;
//                        mf.Id = item.Id;
//                        mf.Id = item.Id;
//                        mf.IsActive = item.IsActive;
//                        fotoList.Add(mf);
//                    }
//                    return Json(fotoList, JsonRequestBehavior.AllowGet);
//                }
//                else
//                {
//                    return Json(null);
//                }
//            }*/
//            return View();
//        }
//        public ActionResult OnizlemeDegistir(string[] fotograflar,int urunId)
//        {
//            /*using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if (kuid != 0)
//                {
//                    var urun = db.Products.SingleOrDefault(x => x.Id == urunId);
//                    urun.Photo = fotograflar[0];
//                    db.SaveChanges();
//                    return Redirect("/Yonetim/Urunler");
//                }
//                else
//                {
//                    return Json(null);
//                }
//            }*/
//            return View();

//        }
//    }
//}