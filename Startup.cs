using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargerInfo.API.Entities;
using ChargerInfo.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChargerInfo.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //var connectionstring = Configuration.GetConnectionString("ChargerInfoDBConnectionString");
            //var connectionstring = Configuration.GetConnectionString("Server=localhost;Database=ChargerInfoDB;Trusted_Connection=True;");
            services.AddDbContext<ChargerInfoContext>(o => o.UseSqlServer("Server=localhost;Database=ChargerInfoDB;Trusted_Connection=True;"));
            services.AddScoped<IChargerInfoRepository, ChargerInfoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ChargerInfoContext chargerInfoContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseStatusCodePages();
            chargerInfoContext.EnsureSeedDataForContext();
            
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
