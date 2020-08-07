using GiftListEditor.BLL.Models;
using GiftListEditor.Models;
using PDWebCore.Attributes;
using PDWebCore.Helpers.MultiLanguage;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace GiftListEditor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var initialState = new[] 
            {
                new GiftModel { Title = "Tall Hat", Price = 49.95 },
                new GiftModel { Title = "Long Cloak", Price = 78.25 }
            };

            return View(initialState);
        }

        [HttpPost]
        public ActionResult Index([FromJson] IEnumerable<GiftModel> gifts)
        {
            // Can process the data any way we want here,
            // e.g., further server-side validation, save to database, etc
            return View("Saved", gifts);
        }  
        

        public ActionResult Introduction()
        {
            return View();
        }

        public ActionResult Collections()
        {
            return View();
        }

        public ActionResult SPA()
        {
            return View();
        }

        public ActionResult CustomBindings()
        {
            return View();
        }


        public ActionResult DataManipulation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DataManipulation([FromJson] IEnumerable<Task> tasks)
        {
            return View("TasksSaved", tasks);
        }


        public ActionResult Demo()
        {
            return View();
        }

        public JsonResult Save(Person person)
        {
            // Just to show we have actually got the data as .NET objects
            var message = string.Format("Saved {0} {1}", person.FirstName, person.LastName);
            message += string.Format(" with {0} friends", person.Friends.Count);
            message += string.Format(" ({0} on Twitter)", person.Friends.Count(f => f.IsOnTwitter));

            return Json(new { message });
        }


        public ActionResult ChangeLanguage(string lang)
        {
            LanguageHelper.SetLanguage(lang);

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}