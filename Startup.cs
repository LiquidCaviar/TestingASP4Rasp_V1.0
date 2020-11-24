using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestingASP4Rasp_V1._0.Data;
using TestingASP4Rasp_V1._0.Services;

namespace TestingASP4Rasp_V1._0
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TutorialDBcontext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("connstring"));
            });
            services.AddTransient<IMailService, NullMailService>();


            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseNodeModules();

            app.UseRouting();

            app.UseEndpoints(cfg => 
            {
                cfg.MapControllerRoute("Fallback",
                     "{controller}/{action}/{id?}",
                     new { controller = "App", action = "Index" }
                    );
                cfg.MapRazorPages();

            });

            
        }
    }
}
