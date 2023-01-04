using System.Collections.Generic;
using System.Linq;
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
                .Include(x => x.EventType)
                .Include(x => x.StringFields)
                .Include(x => x.IntegerFields)
                .Include(x => x.DecimalFields)
                .Include(x => x.BooleanFields);
        }

        public Event Add(Event e)
        {
            _dbContext.Add(e);
            _dbContext.SaveChanges();

            return e;
        }

        public Event GetById(int id)
        {
            return _dbContext.Events
                .Include(x => x.EventTags)
                .Include(x => x.EventType)
                .Include(x => x.StringFields)
                .Include(x => x.IntegerFields)
                .Include(x => x.DecimalFields)
                .Include(x => x.BooleanFields)
                .FirstOrDefault(x => x.ID == id);
        }
    }
}
