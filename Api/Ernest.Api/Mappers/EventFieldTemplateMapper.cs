using System;
using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventFieldTemplateMapper : IApiResponseMapper<EventFieldTemplate, EventFieldTemplateApiResponse>
    {
        public EventFieldTemplateApiResponse MapDbToApiResponse(EventFieldTemplate db)
        {
            return db switch
            {
                EventBooleanFieldTemplate => new EventFieldTemplateApiResponse { Title = db.Title, Type = "Boolean" },
                EventDecimalFieldTemplate => new EventFieldTemplateApiResponse { Title = db.Title, Type = "Decimal" },
                EventIntegerFieldTemplate => new EventFieldTemplateApiResponse { Title = db.Title, Type = "Integer" },
                EventStringFieldTemplate => new EventFieldTemplateApiResponse { Title = db.Title, Type = "String" },
                _ => throw new ArgumentOutOfRangeException(nameof(db))
            };
        }

        public IEnumerable<EventFieldTemplateApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventFieldTemplate> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }
}
