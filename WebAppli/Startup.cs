using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAppli.Data;
using WebAppli.Models;
using WebAppli.Services;
//agrega la session al usuario
using Microsoft.AspNetCore.Session;

namespace WebAppli
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //singleton he siempre intacia la misma intancia asi reinicie el server
            services.AddSingleton<IsingletonInstanceOperation>(new Operation(Guid.Empty));
            // singleton la misma intancia 
            services.AddSingleton<IsingletonOperation, Operation>();
            // cambia cada vez q se hace post
            services.AddScoped<IScodeOperation, Operation>();
            // dinamico 
            services.AddTransient<ITransingOperation, Operation>();


            //sercio

            services.AddTransient<OperationServices, OperationServices>();

            //inyectar el provedor de bd
            services.AddDbContext<AplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("conextion")));

            services.AddScoped<IDataRepository, DataFromClass>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //agrega la session al usuario
            services.AddDistributedMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //session 
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
