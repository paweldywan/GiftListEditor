using GiftListEditor.Attributes;
using GiftListEditor.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GiftListEditor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var initialState = new[] {
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
    }
}