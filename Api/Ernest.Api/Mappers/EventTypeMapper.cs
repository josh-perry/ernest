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

            foreach (var template in db.EventTypeFields)
            {
                fields.AddRange(template.BooleanFields?.Select(field => field.Title) ?? Array.Empty<string>());
                fields.AddRange(template.StringFields?.Select(field => field.Title) ?? Array.Empty<string>());
                fields.AddRange(template.DecimalFields?.Select(field => field.Title) ?? Array.Empty<string>());
                fields.AddRange(template.IntegerFields?.Select(field => field.Title) ?? Array.Empty<string>());
            }

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
