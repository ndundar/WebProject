using Business.Faces;
using System.Web.Mvc;
using DataModel;
namespace WebProject.Controllers
{
    public class TestController : Controller
    {
        private readonly IUserRepository _userRepository;
        public TestController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        // GET: User
        public ActionResult Test()
        {
            this._userRepository.Add(new User
            {
                Mail = "nimet.dundar@g.co",
                Password = "123",
                IsActive = true,

            });
            return View();
        }

    }
}
