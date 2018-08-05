using NumberToWordConverter.App_Start;
using NumberToWordConverter.Framework.Implementation;
using NumberToWordConverter.Framework.Interface;
using NumberToWordConverter.Repository;
using NumberToWordConverter.Repository.Contracts;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace NumberToWordConverter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();

            //Base Registrations Begin
            container.Register<ILogger, FileLogger>(Lifestyle.Singleton);
            container.Register<IConverterRepository, ConverterRepository>(Lifestyle.Singleton);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
