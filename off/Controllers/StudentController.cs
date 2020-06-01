using off.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace off.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        okul_Entities4 db = new okul_Entities4();
        public ActionResult Index(string searching)
        {
            var students = from ogrenci in db.ogrenci 
                           select ogrenci;
            if (!String.IsNullOrEmpty(searching))
            {
                students = students.Where(ogrenci => ogrenci.ogrenci_adi.Contains(searching));

            }
            return View(students.ToList());
        }
    }
}