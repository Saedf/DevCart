using DevCartWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCartWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Contact()
        {
            return View();
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection formCollection)
        //{
        //    var name = formCollection["name"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public JsonResult Contact(Contact contact)
        {
           // Console.WriteLine(contact.ToString());
            return Json(contact);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}