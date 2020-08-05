using GiftListEditor.DAL;
using PDCore.Repositories.Repo;
using PDCoreNew.Services.Serv;
using PDWebCore.Helpers.ExceptionHandling;
using PDWebCore.Helpers.MultiLanguage;
using PDWebCore.Loggers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GiftListEditor
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register); //Musi powyżej RouteConfig
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.RegisterContainer(GlobalConfiguration.Configuration);

            log4net.Config.XmlConfigurator.Configure();

            LogService.EnableLogInDb<WebmailContext, SqlServerWebLogger>();

            SqlRepository.IsLoggingEnabledByDefault = bool.Parse(WebConfigurationManager.AppSettings["IsLoggingEnabledByDefault"]);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            HttpApplicationErrorHandler.HandleLastException(Server, Request, Response);
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            LanguageHelper.SetLanguage(Request);
        }
    }
}
