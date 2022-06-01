using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class studentController1 : Controller
    {
        List<Student> stulist = new List<Student>()
        {
            new Student(){Stuid=1,Stuname="simara",Stuage=20},
            new Student(){Stuid=2,Stuname="dilara",Stuage=22},
            new Student(){Stuid=3,Stuname="albina",Stuage=21},
            new Student(){Stuid=4,Stuname="garanfil",Stuage=18}
        };
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                ViewBag.model = stulist;
                return View();
            }
            else
            {
                foreach(var stu in stulist)
                {
                    if (id == stu.Stuid)
                    {
                        TempData["id"] = stu.Stuid;
                        TempData["name"] = stu.Stuname;
                        TempData["age"] = stu.Stuage;   
                    }
                }
                ViewResult view = new ViewResult();
                view.ViewName = "Index";
                return view;
            }
        }
    }
}
