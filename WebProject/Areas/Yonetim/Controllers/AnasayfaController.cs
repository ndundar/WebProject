//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

///*namespace WebProject.Areas.Yonetim.Controllers
//{
//    [Authorize]
//      public class AnasayfaController : Controller
//  {
//        // GET: Yonetim/Anasayfa
//       [Route("Anasayfa")]
//        public ActionResult Index()
//        {
//            using (ProjectEntitie db = new ProjectEntitie())
//            {
//                int kuid = Convert.ToInt32(Session["kuid"]);
//                if(kuid!=0)
//                {
//                    return View();

//                }
//                else
//                {
//                    return Redirect("/Yonetim/Index");
//                }

//            }
//        }
        
//    }
//}