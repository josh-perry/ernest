using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ernest.Api
{
    public static class DatabaseSeeder
    {
        public static void SeedDatabase(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.Migrate();

            if (dbContext.EventTypes.FirstOrDefault() != null)
                return;

            AddEventTypes(dbContext);
        }

        private static async void AddEventTypes(ApplicationDbContext dbContext)
        {
            var eventTypes = new List<EventType>
            {
                new EventType
                {
                    Title = "Tea"
                },

                new EventType
                {
                    Title = "Weigh-in",
                    DecimalFields = new List<EventDecimalFieldTemplate>
                    {
                        new EventDecimalFieldTemplate
                        {
                            Title = "Weight (lb)",
                            Priority = 1
                        }
                    }
                },

                new EventType
                {
                    Title = "Ideas",
                    StringFields = new List<EventStringFieldTemplate>
                    {
                        new EventStringFieldTemplate
                        {
                            Title = "Idea",
                            Priority = 1
                        }
                    }
                }
            };

            await dbContext.AddRangeAsync(eventTypes);
            await dbContext.SaveChangesAsync();
        }
    }
}
