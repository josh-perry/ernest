using System;
using System.IO;
using System.Reflection;
using Ernest.Api.Data;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;
using Ernest.Api.Repositories;
using Ernest.Api.Repositories.Interfaces;
using Ernest.Api.Services;
using Ernest.Api.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            services.AddSingleton<IApiResponseMapper<EventTag, EventTagApiResponse>, EventTagMapper>();
            services.AddSingleton<IApiResponseMapper<Event, EventApiResponse>, EventMapper>();
            services.AddSingleton<IApiResponseMapper<EventType, EventTypeApiResponse>, EventTypeMapper>();
            services.AddSingleton<IApiResponseMapper<EventField, EventFieldApiResponse>, EventFieldMapper>();
            services.AddSingleton<IApiResponseMapper<EventFieldTemplate, EventFieldTemplateApiResponse>, EventFieldTemplateMapper>();

            // Repositories
            services.AddTransient<IEventTagsRepository, EventTagsRepository>();
            services.AddTransient<IEventTypeRepository, EventTypeRepository>();
            services.AddTransient<IEventFieldRepository, EventFieldRepository>();
            services.AddTransient<IEventRepository, EventRepository>();

            // Services
            services.AddTransient<IEventValidator, EventValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.SeedDatabase(env);

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
