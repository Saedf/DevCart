using DevCartWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCartWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new()
        {
            new Service(1,"نقره ایی"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services,"Id","Name"),
            };
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection formCollection)
        //{
        //    var name = formCollection["name"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            // Console.WriteLine(contact.ToString());
            //return Json(contact);
            //var model = new Contact();
            //return View(model);
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
               ViewBag.error = "اطلاعات وارد شده صحیح نیست ";
                return View(model); 
            }
            ModelState.Clear();
             model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name"),
            };
            ViewBag.success = "پیغام شما با  موفقیت ازسال شد .";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}