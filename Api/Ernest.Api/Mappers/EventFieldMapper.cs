using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventStringFieldMapper : IApiResponseMapper<EventStringFieldTemplate, EventFieldApiResponse>
    {
        public EventFieldApiResponse MapDbToApiResponse(EventStringFieldTemplate db)
        {
            return new EventFieldApiResponse
            {
                Title = db.Title,
                Type = "String"
            };
        }

        public IEnumerable<EventFieldApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventStringFieldTemplate> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }

    public class EventDecimalFieldMapper : IApiResponseMapper<EventDecimalFieldTemplate, EventFieldApiResponse>
    {
        public EventFieldApiResponse MapDbToApiResponse(EventDecimalFieldTemplate db)
        {
            return new EventFieldApiResponse
            {
                Title = db.Title,
                Type = "Decimal"
            };
        }

        public IEnumerable<EventFieldApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventDecimalFieldTemplate> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }

    public class EventIntegerFieldMapper : IApiResponseMapper<EventIntegerFieldTemplate, EventFieldApiResponse>
    {
        public EventFieldApiResponse MapDbToApiResponse(EventIntegerFieldTemplate db)
        {
            return new EventFieldApiResponse
            {
                Title = db.Title,
                Type = "Integer"
            };
        }

        public IEnumerable<EventFieldApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventIntegerFieldTemplate> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }

    public class EventBooleanFieldMapper : IApiResponseMapper<EventBooleanFieldTemplate, EventFieldApiResponse>
    {
        public EventFieldApiResponse MapDbToApiResponse(EventBooleanFieldTemplate db)
        {
            return new EventFieldApiResponse
            {
                Title = db.Title,
                Type = "Boolean"
            };
        }

        public IEnumerable<EventFieldApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventBooleanFieldTemplate> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }
}
