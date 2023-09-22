using Microsoft.AspNetCore.Mvc;
using Tp_MVC.Models;

namespace Tp_MVC.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("obtener_todo")]
        public IActionResult GetList()
        {
            var user = new UserModel
            {
                Name = "Maxi",
                Surname = "Mainero"
            };

            return View("Index", user);
        }
    }
}
