using Microsoft.AspNetCore.Mvc;
using Tp.MVC;
using Tp_MVC.Models;

namespace Tp_MVC.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("obtener-datos-usuarios")]
        public IActionResult GetList()
        {
            var user = new UserModel
            {
                Name = "Maxi",
                Surname = "Mainero"
            };

            return View("Index", user);
        }
        public IActionResult GetListAddress()
        {
            var service = new ServiceClient();
            var address = service.GetAddress(int.MaxValue);

            return View("Index", address);
        }
    }
}
