using System.Collections.Generic;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Repositories.Interfaces
{
    public interface IEventFieldRepository
    {
        IEnumerable<EventFieldTemplate> GetAllTemplatesForEventType(EventType eventType);

        IEnumerable<EventBooleanFieldTemplate> GetBooleanTemplatesForEventType(EventType eventType);

        IEnumerable<EventStringFieldTemplate> GetStringTemplatesForEventType(EventType eventType);

        IEnumerable<EventDecimalFieldTemplate> GetDecimalTemplatesForEventType(EventType eventType);

        IEnumerable<EventIntegerFieldTemplate> GetIntegerTemplatesForEventType(EventType eventType);

        void AddEventFields(Event e, Dictionary<string, object> fields);
    }
}
