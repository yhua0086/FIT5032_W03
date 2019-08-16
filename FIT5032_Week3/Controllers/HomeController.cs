using FIT5032_Week3.Exercise;
using FIT5032_Week3.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();

            //this following two lane are about dictionary method
            ExampleDictionary ed = new ExampleDictionary();
            ed.Example();

            return View();
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}