using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tp.MVC;
using Tp_MVC.Models;

namespace Tp_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var service = new ServiceClient();
            var address = service.GetAddress(int.MaxValue);

            return View(address);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}