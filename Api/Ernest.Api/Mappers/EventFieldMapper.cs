using System;
using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventFieldMapper : IApiResponseMapper<EventField, EventFieldApiResponse>
    {
        public EventFieldApiResponse MapDbToApiResponse(EventField db)
        {
            return db switch
            {
                EventBooleanField b => new EventFieldApiResponse { Title = db.Title, Type = "Boolean", Value = b.Boolean },
                EventDecimalField d => new EventFieldApiResponse { Title = db.Title, Type = "Decimal", Value = d.Decimal },
                EventIntegerField i => new EventFieldApiResponse { Title = db.Title, Type = "Integer", Value = i.Integer },
                EventStringField s => new EventFieldApiResponse { Title = db.Title, Type = "String", Value = s.String },
                _ => throw new ArgumentOutOfRangeException(nameof(db))
            };
        }

        public IEnumerable<EventFieldApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventField> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }
}