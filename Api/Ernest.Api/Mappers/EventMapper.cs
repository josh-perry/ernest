using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Extensions;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventMapper : IApiResponseMapper<Event, EventApiResponse>
    {
        private readonly IApiResponseMapper<EventTag, EventTagApiResponse> _eventTagMapper;
        
        private readonly IApiResponseMapper<EventField, EventFieldApiResponse> _eventFieldsMapper;

        public EventMapper(
            IApiResponseMapper<EventTag, EventTagApiResponse> eventTagMapper,
            IApiResponseMapper<EventField, EventFieldApiResponse> eventFieldsMapper)
        {
            _eventTagMapper = eventTagMapper;
            _eventFieldsMapper = eventFieldsMapper;
        }

        public EventApiResponse MapDbToApiResponse(Event db)
        {
            return new EventApiResponse
            {
                ID = db.ID,
                Description = db.Description,
                Title = db.Title,
                DateTime = db.DateTime,
                EventTags = _eventTagMapper.MapDbToApiResponseEnumerable(db.EventTags ?? new List<EventTag>()),
                EventType = db.EventType?.Title,
                EventFields = _eventFieldsMapper.MapDbToApiResponseEnumerable(db.GetAllEventFields())
            };
        }

        public IEnumerable<EventApiResponse> MapDbToApiResponseEnumerable(IEnumerable<Event> db)
        {
            return db.ToList().Select(MapDbToApiResponse).ToList();
        }
    }
}
