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
            return dbContext;
        }

        private static void AddEventTags(ApplicationDbContext dbContext)
        {
            dbContext.EventTags.Add(new EventTag
            {
                Title = "TestTag"
            });

            dbContext.EventTags.Add(new EventTag
            {
                Title = "TestTag2"
            });

            dbContext.EventTags.Add(new EventTag
            {
                Title = "TestTag3"
            });

            dbContext.SaveChanges();
        }
    }
}
