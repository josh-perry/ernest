using System;
using System.IO;
using System.Reflection;
using Ernest.Api.Data;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;
using Ernest.Api.Repositories;
using Ernest.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Ernest.Api
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
            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllers();

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Ernest.Api",
                    Version = "v1"
                });

                // Source: https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            // Mappers
            services.AddSingleton<IApiResponseMapper<EventTag, EventTagApiResponse>, EventTagsMapper>();
            services.AddSingleton<IApiResponseMapper<Event, EventApiResponse>, EventMapper>();

            // Repositories
            services.AddTransient<IEventTagsRepository, EventTagsRepository>();
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

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ernest.Api");
            });

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
