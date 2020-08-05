using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using GiftListEditor.BLL.Models;
using GiftListEditor.DAL;
using GiftListEditor.DAL.Repositories;
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

            builder.RegisterType<WebmailContext>()
                   .As<IEntityFrameworkDbContext>()
                   .As<IMainDbContext>();

            builder.RegisterType<LogMessageFactory>()
                   .As<ILogMessageFactory>();

            builder.RegisterType<FileLogger>()
                   .As<ILogger>();

            builder.RegisterGeneric(typeof(SqlRepositoryEntityFrameworkDisconnected<>))
                   .As(typeof(ISqlRepositoryEntityFrameworkDisconnected<>))
                   .InstancePerRequest();

            builder.RegisterType<MailRepository>()
                   .As<IMailRepository>()
                   .InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}