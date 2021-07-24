using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Ernest.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ernest.Api.Repositories
{
    public class EventTypeRepository : IEventTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EventTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<EventType> GetAll()
        {
            return _dbContext.EventTypes
                .Include(x => x.BooleanFields)
                .Include(x => x.StringFields)
                .Include(x => x.IntegerFields)
                .Include(x => x.DecimalFields);
        }

        public IQueryable<EventType> GetByName(string name)
        {
            return _dbContext.EventTypes
                .Where(x => x.Title == name)
                .Include(x => x.BooleanFields)
                .Include(x => x.StringFields)
                .Include(x => x.IntegerFields)
                .Include(x => x.DecimalFields);
        }

        public IEnumerable<EventType> GetByName(IEnumerable<string> names)
        {
            return _dbContext.EventTypes
                .Where(x => names.Contains(x.Title))
                .Include(x => x.BooleanFields)
                .Include(x => x.StringFields)
                .Include(x => x.IntegerFields)
                .Include(x => x.DecimalFields);
        }
    }
}
