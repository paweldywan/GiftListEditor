using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GiftListEditor.DAL;
using PDCore.Factories.Fac;
using PDCore.Factories.IFac;
using PDCore.Interfaces;
using PDCore.Repositories.IRepo;
using PDCoreNew.Context.IContext;
using PDCoreNew.Loggers;
using PDCoreNew.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GiftListEditor
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType(typeof(SqlRepositoryEntityFrameworkAsync<>))
                   .As(typeof(ISqlRepositoryEntityFrameworkDisconnected<>))
                   .InstancePerRequest();

            builder.RegisterType<WebmailContext>()
                   .As<IEntityFrameworkDbContext>();

            builder.RegisterType<WebmailContext>()
                   .As<IMainDbContext>();

            builder.RegisterType<TraceLogger>()
                   .As<ILogger>();

            builder.RegisterType<LogMessageFactory>()
                   .As<ILogMessageFactory>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}