using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cadastro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Senha",
                "Senha",
                new { controller = "Senha", action = "RecuperarSenha", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Cadastro",
                "Cadastro",
                new { controller = "Cadastro", action = "Cadastrar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Funcionario",
                "Funcionario",
                new { controller = "Conta", action = "Funcionarios", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
