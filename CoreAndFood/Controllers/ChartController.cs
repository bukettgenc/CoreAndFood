using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class1> ProList()
        {
            List<Class1> cs=new List<Class1>();
            cs.Add(new Class1()
            {
                proName = "computer",
                stock = 150
            });
            cs.Add(new Class1()
            {
                proName = "lcd",
                stock = 75
            });
            cs.Add(new Class1()
            {
                proName = "usbDisk",
                stock = 220
            });
            return cs;
        }
    }
}
