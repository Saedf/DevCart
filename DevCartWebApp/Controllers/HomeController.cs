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
        public IActionResult Contact(Contact contact)
        {
            // Console.WriteLine(contact.ToString());
            //return Json(contact);
            //var model = new Contact();
            //return View(model);
            if (!ModelState.IsValid)
            {
               ViewBag.error = "اطلاعات وارد شده صحیح نیست ";
                return View(contact); 
            }

            ViewBag.success = "پیغام شما با  موفقیت ازسال شد .";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}