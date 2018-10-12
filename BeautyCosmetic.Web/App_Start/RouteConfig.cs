using System.Web.Mvc;
using System.Web.Routing;

namespace BeautyCosmetic.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
      name: "Search",
      url: "tim-kiem",
      defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
      namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
  );
            routes.MapRoute(
         name: "Login",
         url: "dang-nhap",
         defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
         namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
     );
            routes.MapRoute(
           name: "About",
           url: "gioi-thieu.html.",
           defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
           namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
       );
            routes.MapRoute(
             name: "Product Category",
             url: "{alias}_pc-{id}",
             defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
               namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
         );

            routes.MapRoute(
             name: "Product",
             url: "{alias}_p-{productId}",
             defaults: new { controller = "Product", action = "Detail", productId = UrlParameter.Optional },
               namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  namespaces: new string[] { "BeautyCosmetic.Web.Controllers" }
            );
        }
    }
}