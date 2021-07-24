using System;
using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventTypeMapper : IApiResponseMapper<EventType, EventTypeApiResponse>
    {
        public EventTypeApiResponse MapDbToApiResponse(EventType db)
        {
            var fields = new List<string>();
            fields.AddRange(db.BooleanFields?.Select(field => field.Title) ?? Array.Empty<string>());
            fields.AddRange(db.StringFields?.Select(field => field.Title) ?? Array.Empty<string>());
            fields.AddRange(db.DecimalFields?.Select(field => field.Title) ?? Array.Empty<string>());
            fields.AddRange(db.IntegerFields?.Select(field => field.Title) ?? Array.Empty<string>());

            return new EventTypeApiResponse
            {
                Title = db.Title,
                Fields = fields
            };
        }

        public IEnumerable<EventTypeApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventType> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }
}
