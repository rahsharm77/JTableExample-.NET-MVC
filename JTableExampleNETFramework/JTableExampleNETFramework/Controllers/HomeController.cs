using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using JTableExampleNETFramework.Models;
using System.Web.Mvc;

namespace JTableExampleNETFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Added as an example to populate our dummy list
        [HttpPost]
        public JsonResult GetItems()
        {
            try
            {
                //Add to our list
                List<Student> studentList = new List<Student>()
                {
                  new Student(){ StudentID=1, StudentName="Bill"},
                  new Student(){ StudentID=2, StudentName="Steve"},
                  new Student(){ StudentID=3, StudentName="Ram"},
                  new Student(){ StudentID=4, StudentName="Moin"}
                };

                //var json = JsonConvert.SerializeObject(studentList);
                return Json(new { Result = "OK", Records = studentList, TotalRecordCount = studentList.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}