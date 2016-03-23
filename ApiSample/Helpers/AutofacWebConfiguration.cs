using ApiSample.Services.BusinessLogicServices;
using ApiSample.Services.BusinessLogicServices.Interfaces;
using ApiSample.Services.Repositories;
using ApiSample.Services.Repositories.Interfaces;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using ApiSample.Context;

namespace ApiSample.Helpers
{
    public class AutofacWebConfiguration
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();
            AddRegisterations(builder);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // Set the dependency resolver for Web API.
            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;
        }

        private static void AddRegisterations(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            builder.RegisterType<InstagramApiService>().As<IInstagramApiService>().InstancePerRequest();
            builder.RegisterType<FavoriteCreationService>().As<IFavoriteCreationService>().InstancePerRequest();
            builder.RegisterType<FavoriteQueryService>().As<IFavoriteQueryService>().InstancePerRequest();
            builder.RegisterType<FavoriteRepository>().As<IFavoriteRepository>().InstancePerRequest();
            builder.RegisterType<DbContextScopeFactory>().As<IDbContextScopeFactory>().InstancePerRequest();
            builder.RegisterType<AmbientDbContextLocator>().As<IAmbientDbContextLocator>().InstancePerRequest();
        }
    }
}