using GiftListEditor.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using PDWebCore.Attributes;
using System.Web.Mvc.Html;
using System.Web;
using System.Security.Policy;

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

    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString HashLink(this HtmlHelper htmlHelper, string text, string className = "")
        {
            _ = htmlHelper;

            var anchor = new TagBuilder("a")
            {
                InnerHtml = text
            };

            anchor.Attributes.Add("href", "#");

            if (!string.IsNullOrWhiteSpace(className))
            {
                anchor.AddCssClass(className);
            }

            return MvcHtmlString.Create(anchor.ToString());
        }

        public static MvcHtmlString ActionLinkWithHash(this HtmlHelper htmlHelper, string linkText, string hashText, string actionName, string controllerName)
        {
            _ = htmlHelper;

            var requestContext = HttpContext.Current.Request.RequestContext;

            var urlHelper = new UrlHelper(requestContext);

            var urlAction = urlHelper.Action(actionName, controllerName);

            var anchor = new TagBuilder("a")
            {
                InnerHtml = linkText
            };

            anchor.Attributes.Add("href", $"{urlAction}#{hashText}");

            return MvcHtmlString.Create(anchor.ToString());
        }
    }
}