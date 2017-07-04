using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Fiver.Api.Paging.OtherLayers;

namespace Fiver.Api.Paging
{
    public class Startup
    {
        public Startup(
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
        }

        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();
            
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
        }
    }
}
