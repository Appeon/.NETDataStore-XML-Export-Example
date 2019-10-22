using System;
using System.IO.Compression;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;
using SnapObjects.Data.AspNetCore;
using DWNet.Data.AspNetCore;

namespace XmlDataDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(m =>
            {
                m.UseCoreIntegrated();

                m.UsePowerBuilderIntegrated();
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            // Uncomment the following line to connect to the SQL server database.
            // Note: Replace "ContextName" with the configured context name; replace "key" with the database connection name that exists in appsettings.json. The sample code is as follows:
            services.AddDataContext<SampleDataContext>(m => m.UseSqlServer(Configuration["ConnectionStrings:local"]));

            services.AddScoped<ISampleService, SampleService>();
			
            services.AddGzipCompression(CompressionLevel.Fastest);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            
            app.UseResponseCompression();

            app.UseMvc();

            app.UseDataWindow();
        }
    }
}