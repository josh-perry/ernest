using Ernest.Api.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace Ernest.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventTag> EventTags { get; set; }

        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<EventBooleanField> EventBooleanFields { get; set; }

        public DbSet<EventStringField> EventStringFields { get; set; }

        public DbSet<EventIntegerField> EventIntegerFields { get; set; }

        public DbSet<EventDecimalField> EventDecimalFields { get; set; }
    }
}
