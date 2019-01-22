using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinKatanaDemo
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";

        //    using (WebApp.Start<Startup>(uri))
        //    {
        //        Console.WriteLine("Started");
        //        Console.ReadKey();
        //        Console.WriteLine("Stopping!");
        //    }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureWebApi(app);

            //The block of code below are for logging all the requests/responses happening while running.
            app.Use(async (enviroment, next) =>
            {
                Console.WriteLine("Requesting : " + enviroment.Request.Path);

                await next();

                Console.WriteLine("Response : " + enviroment.Response.StatusCode);
            });
            //The code below does the main work of running this app.
            app.Use<HelloWorldComponent>();
        }

        //The method below configures our http routes so that we can use the different controllers.
        private void ConfigureWebApi(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            //Below is the structure for the http routes the website will have.
            config.Routes.MapHttpRoute("DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }

        public class HelloWorldComponent
        {
            AppFunc _next;

            public HelloWorldComponent(AppFunc next)
            {
                _next = next;
            }
            public Task Invoke(IDictionary<string, object> enviroment)
            {
                var response = enviroment["owin.ResponseBody"] as Stream;
                using (var writer = new StreamWriter(response))
                {
                    return writer.WriteAsync("Hello!");
                }
            }
        }
    }
}
