using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
            var booleanFields = GetBooleanTemplatesForEventType(eventType);
            var stringFields = GetStringTemplatesForEventType(eventType);
            var decimalFields = GetDecimalTemplatesForEventType(eventType);
            var integerFields = GetIntegerTemplatesForEventType(eventType);

            return booleanFields.Concat<EventFieldTemplate>(stringFields).Concat(decimalFields).Concat(integerFields);
        }

        public IEnumerable<EventBooleanFieldTemplate> GetBooleanTemplatesForEventType(EventType eventType)
        {
            return _dbContext.EventBooleanFieldTemplates.Where(x => x.EventType == eventType).ToList();
        }

        public IEnumerable<EventStringFieldTemplate> GetStringTemplatesForEventType(EventType eventType)
        {
            return _dbContext.EventStringFieldTemplates.Where(x => x.EventType == eventType).ToList();
        }

        public IEnumerable<EventDecimalFieldTemplate> GetDecimalTemplatesForEventType(EventType eventType)
        {
            return _dbContext.EventDecimalFieldTemplates.Where(x => x.EventType == eventType).ToList();
        }

        public IEnumerable<EventIntegerFieldTemplate> GetIntegerTemplatesForEventType(EventType eventType)
        {
            return _dbContext.EventIntegerFieldTemplates.Where(x => x.EventType == eventType).ToList();
        }

        public void AddEventFields(Event e, Dictionary<string, object> fields)
        {
            var booleanFields = _dbContext.EventBooleanFieldTemplates.Where(x => x.EventType == e.EventType).ToList();
            var stringFields = _dbContext.EventStringFieldTemplates.Where(x => x.EventType == e.EventType).ToList();
            var decimalFields = _dbContext.EventDecimalFieldTemplates.Where(x => x.EventType == e.EventType).ToList();
            var integerFields = _dbContext.EventIntegerFieldTemplates.Where(x => x.EventType == e.EventType).ToList();

            // TODO: make this less bad
            foreach (var (key, v) in fields)
            {
                var decimalField = decimalFields.FirstOrDefault(x => x.Title == key);
                if (decimalField != null)
                {
                    var decimalValue = (v is JsonElement value ? value : default).GetDecimal();
                    AddDecimalValue(key, decimalValue, e);
                    continue;
                }

                var booleanField = booleanFields.FirstOrDefault(x => x.Title == key);
                if (booleanField != null)
                {
                    var booleanValue = (v is JsonElement value ? value : default).GetBoolean();
                    AddBooleanValue(key, booleanValue, e);
                    continue;
                }

                var stringField = stringFields.FirstOrDefault(x => x.Title == key);
                if (stringField != null)
                {
                    var stringValue = (v is JsonElement value ? value : default).GetString();
                    AddStringValue(key, stringValue, e);
                    continue;
                }

                var integerField = integerFields.FirstOrDefault(x => x.Title == key);
                if (integerField != null)
                {
                    var integerValue = (v is JsonElement value ? value : default).GetInt32();
                    AddIntegerValue(key, integerValue, e);
                    continue;
                }
            }

            _dbContext.SaveChanges();
        }

        private void AddIntegerValue(string title, int value, Event e)
        {
            var integerFieldEntry = new EventIntegerField
            {
                Title = title,
                Integer = value,
                CreatedDateTime = DateTime.UtcNow,
                LastEditedDateTime = DateTime.UtcNow,
                Event = e
            };

            _dbContext.Add(integerFieldEntry);
        }

        private void AddStringValue(string title, string value, Event e)
        {
            var stringFieldEntry = new EventStringField
            {
                Title = title,
                String = value,
                CreatedDateTime = DateTime.UtcNow,
                LastEditedDateTime = DateTime.UtcNow,
                Event = e
            };

            _dbContext.Add(stringFieldEntry);
        }

        private void AddBooleanValue(string title, bool value, Event e)
        {
            var booleanFieldEntry = new EventBooleanField
            {
                Title = title,
                Boolean = value,
                CreatedDateTime = DateTime.UtcNow,
                LastEditedDateTime = DateTime.UtcNow,
                Event = e
            };

            _dbContext.Add(booleanFieldEntry);
        }

        private void AddDecimalValue(string title, decimal value, Event e)
        {
            var decimalFieldEntry = new EventDecimalField
            {
                Title = title,
                Decimal = value,
                CreatedDateTime = DateTime.UtcNow,
                LastEditedDateTime = DateTime.UtcNow,
                Event = e
            };

            _dbContext.Add(decimalFieldEntry);
        }
    }
}
