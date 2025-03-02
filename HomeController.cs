using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            //return View("~/TempView/NitishTemp.cshtml");
            return View();
            
         //   var obj = new { id = 1, name = "maroosh" };

   //Return view from action method with model
           // return View(obj);
           // return View("About Us",obj);
   //Return view from action method
            // return View("About Us");
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }

        public ViewResult Footer()
        {
            return View();
        }
    }
}
