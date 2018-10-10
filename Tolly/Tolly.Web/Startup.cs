using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tolly.Domain.Services;
using Tolly.Infrastructure;

namespace Tolly.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Val av tullräknare

            services.AddTransient<ITollCalculator, TollCalculator>();

            // Val av datakälla

            services.AddTransient<IVechicleReader, AlternativeFileVechicleReader>();
            //services.AddTransient<IVechicleReader, FileVechicleReader>();
            //services.AddTransient<IVechicleReader, WebVechicleReader>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
