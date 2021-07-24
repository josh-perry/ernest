using System.Collections.Generic;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Ernest.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ernest.Api.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EventRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Event> GetAll()
        {
            return _dbContext.Events
                .Include(x => x.EventTags)
                .Include(x => x.EventType);
        }

        public Event Add(Event e)
        {
            _dbContext.Add(e);
            _dbContext.SaveChanges();

            return e;
        }
    }
}
