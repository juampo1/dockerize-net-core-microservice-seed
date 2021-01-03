using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model.Services;
using Model.Repositories;
using Persistence.Repositories;
using System;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace ProductServiceHost.Configuration
{
    class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddSwaggerGen((Action<SwaggerGenOptions>)(options =>
           {
               options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
               {
                   Title = "ProductService"
               });
           }));

            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IRepositoryFactory, RepositoryFactory>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseSwagger((Action<Swashbuckle.AspNetCore.Swagger.SwaggerOptions>)(Action<SwaggerGenOptions>) null).UseSwaggerUI((Action<SwaggerUIOptions>)(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1")));
        }
    }
}
