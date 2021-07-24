using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Ernest.Api.Repositories.Interfaces;

namespace Ernest.Api.Repositories
{
    public class EventFieldRepository : IEventFieldRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EventFieldRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<EventFieldTemplate> GetAllTemplatesForEventType(EventType eventType)
        {
            var booleanFields = _dbContext.EventBooleanFieldTemplates.Where(x => x.EventType == eventType).ToList();
            var stringFields = _dbContext.EventStringFieldTemplates.Where(x => x.EventType == eventType).ToList();
            var decimalFields = _dbContext.EventDecimalFieldTemplates.Where(x => x.EventType == eventType).ToList();
            var integerFields = _dbContext.EventIntegerFieldTemplates.Where(x => x.EventType == eventType).ToList();

            return booleanFields.Concat<EventFieldTemplate>(stringFields).Concat(decimalFields).Concat(integerFields);
        }
    }
}
