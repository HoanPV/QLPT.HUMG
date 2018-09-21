using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using SimpleInjector;
using QLPT.HUMG.BLL.IBusinessService;
using QLPT.HUMG.BLL.BusinessService;
using QLPT.HUMG.App_Start;
using QLPT.HUMG.DAL.Interfaces;
using DAL.Repositories;


namespace QLPT.HUMG
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
            "text/html", StringComparison.InvariantCultureIgnoreCase, true, "application/json"));
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();
            container.Register<IKhachHangService, KhachHangService>();
            container.Register<IPhongService, PhongService>();
            container.Register<INhaTroService, NhaTroService>();
            container.Register<IDichVuService, DichVuService>();

            container.Register<IKhachHangRepository, KhachHangRepository>();
            container.Register<IPhongRepository, PhongRepository>();
            container.Register<INhaTroRepository, NhaTroRepository>();
            container.Register<IDichVuRepository, DichVuRepository>();

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
        }
    }
}