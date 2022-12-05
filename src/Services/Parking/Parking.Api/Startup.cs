using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Parking.Persistence.Database;
using Parking.Service.Queries;
using Parking.Service.Queries.IRepositories;
using Parking.Service.Queries.IServices;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using AspNet.HealthChecks.UI.Client;

namespace Parking.Api
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
            //base de datos
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("Conexion"),
                //Tabla de migraciones
                x => x.MigrationsHistoryTable("__EFMigrationsHistory","Parking"))
            );


            //Services
            services.AddMediatR(Assembly.Load("Parking.Service.EventHandlers"));

           
            services.AddScoped<IParqueaderoService, ParqueaderoQueryService>();

            //validar niestso servicios
            services.AddHealthChecks()
                      .AddCheck("self", () => HealthCheckResult.Healthy())
                      .AddCheck("Customer.Api.Check", () => HealthCheckResult.Healthy())
                      .AddDbContextCheck<ApplicationDbContext>(typeof(ApplicationDbContext).Name);

            services.AddHealthChecksUI();

            services.AddControllers();

            //Repositorys
        

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            app.UseRouting();

            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapHealthChecks("/hc", new HealthCheckOptions()
                {
                    Predicate = _ => true,
                   // ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse

                });
                endpoints.MapHealthChecksUI();
                endpoints.MapControllers();
            });
        }
       
    }
}
