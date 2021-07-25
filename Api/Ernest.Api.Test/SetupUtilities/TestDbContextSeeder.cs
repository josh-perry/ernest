using System.Collections.Generic;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace Ernest.Api.Test.SetupUtilities
{
    public static class TestDbContextSeeder
    {
        private static readonly DbContextOptions<ApplicationDbContext> DbContextOptions;

        static TestDbContextSeeder()
        {
            DbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
        }

        public static ApplicationDbContext InitializeDatabase()
        {
            var dbContext = new ApplicationDbContext(DbContextOptions);
            dbContext.Database.EnsureDeleted();

            AddEventTags(dbContext);
            AddEventTypes(dbContext);
            return dbContext;
        }

        private static void AddEventTags(ApplicationDbContext dbContext)
        {
            var tags = new[]
            {
                "TestTag", "TestTag2", "TestTag3"
            };

            foreach (var tag in tags)
            {
                dbContext.EventTags.Add(new EventTag
                {
                    Title = tag
                });
            }

            dbContext.SaveChanges();
        }

        private static void AddEventTypes(ApplicationDbContext dbContext)
        {
            var eventTypes = new List<EventType>
            {
                new()
                {
                    Title = "Tea"
                },

                new()
                {
                    Title = "Weigh-in",
                    DecimalFields = new List<EventDecimalFieldTemplate>
                    {
                        new()
                        {
                            Title = "Weight (lb)",
                            Priority = 1
                        }
                    }
                },

                new()
                {
                    Title = "Ideas",
                    StringFields = new List<EventStringFieldTemplate>
                    {
                        new()
                        {
                            Title = "Idea",
                            Priority = 1
                        }
                    }
                },

                new()
                {
                    Title = "Mood",
                    IntegerFields = new List<EventIntegerFieldTemplate>
                    {
                        new()
                        {
                            Title = "Mood",
                            Priority = 1
                        }
                    },
                    StringFields = new List<EventStringFieldTemplate>
                    {
                        new()
                        {
                            Title = "Notes",
                            Priority = 2
                        }
                    }
                }
            };

            dbContext.AddRange(eventTypes);
            dbContext.SaveChanges();
        }
    }
}
