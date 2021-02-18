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
           
            //services.AddScoped<IRepositoryManager, RepositoryManager>();
            //Bij elke Http Request wordt er nieuw object van RepositoryManager class aangemaakt
            //en dit object wordt via de constructor (bv bij StudentsController) automatisch geïnjecteerd

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
