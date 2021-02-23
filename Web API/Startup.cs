using Contracts;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API
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
        //IoC Container die gaat objecten creëren voor de services en levensduur beheren
        {
            //this is where you add ref to repositoryContext, boven de AddControllers
            services.AddDbContext<RepositoryContext>(                                                   //add reference to entities
                opts => opts.UseSqlServer(Configuration.GetConnectionString("sqlConnection"),
                opts => opts.MigrationsAssembly("Web API")));                           //Hier naam van waar je het wilt, dus in project Web API
                                                                                        //then add-migration Init and update-database into the Web API
                                                                                        // check database en maak de IRepositoryBase en manager aan in contracts

            //add reference to repository
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            //Bij elke Http Request wordt er nieuw object van RepositoryManager class aangemaakt
            //en dit object wordt via de constructor (bv bij StudentsController) automatisch geïnjecteerd

            services.AddControllers();

            //add swashbuckle.aspnetcore packages 
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Boekhouding API",
                    Version = "v1"
                });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            //hiertussen swagger -- dan ook in launchSettings.json
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
            });


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
