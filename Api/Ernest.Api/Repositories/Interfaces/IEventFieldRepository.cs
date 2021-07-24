using System.Collections.Generic;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Repositories.Interfaces
{
    public interface IEventFieldRepository
    {
        IEnumerable<EventFieldTemplate> GetAllTemplatesForEventType(EventType eventType);
    }
}
