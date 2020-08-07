using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftListEditor.Controllers
{
    public class CoursesController  : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WithoutDataBinding()
        {
            return View();
        }
    }
}