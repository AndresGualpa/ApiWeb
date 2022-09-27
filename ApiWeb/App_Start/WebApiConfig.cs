using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // aceptacion de metodos de nuestra apiweb 
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            //

            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Transforma las peticiones a modo JSON
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
                .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept", "text/html",
                StringComparison.InvariantCultureIgnoreCase, true, "application/json"));
        }
    }
}
