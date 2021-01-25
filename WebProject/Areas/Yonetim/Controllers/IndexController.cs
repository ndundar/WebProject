//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Security;

//namespace WebProject.Areas.Yonetim.Controllers
//{
//    public class IndexController : Controller
//    {
//        // GET: Yonetim/Index
//        [Route("Index")]
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Index(string mail,string password)
//        {
//            /* using (ProjectEntitie db = new ProjectEntitie())
//             {
//                 var user = db.User.SingleOrDefault(x => x.Mail == mail && x.Password == password);
//                 if(user!=null)
//                 {
//                     FormsAuthentication.SetAuthCookie(user.Mail, true);
//                     Session["kuid"] = user.Id;
//                     return Redirect("/Yonetim/Anasayfa");
//                 }
//                 else
//                 {
//                     ViewBag.Hata = "Kullanıcı adı veya şifrenizi yalnış girdiniz.Lütfen tekrar deneyiniz";
//                     return View();
//                 }
//            }*/

//            return View();

//        }
//        public ActionResult CikisYap()
//        {
//            /*FormsAuthentication.SignOut();
//            Session.Remove("kuid");*/
//            return Redirect("/Yonetim/Index");
//        }
//    }
//}