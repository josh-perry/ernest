using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventMapper : IApiResponseMapper<Event, EventApiResponse>
    {
        private readonly IApiResponseMapper<EventTag, EventTagApiResponse> _eventTagMapper;

        public EventMapper(IApiResponseMapper<EventTag, EventTagApiResponse> eventTagMapper)
        {
            _eventTagMapper = eventTagMapper;
        }

        public EventApiResponse MapDbToApiResponse(Event db)
        {
            return new EventApiResponse
            {
                Description = db.Description,
                Title = db.Title,
                DateTime = db.DateTime,
                EventTags = _eventTagMapper.MapDbToApiResponseEnumerable(db.EventTags ?? new List<EventTag>()),
                EventType = db.EventType?.Title
            };
        }

        public IEnumerable<EventApiResponse> MapDbToApiResponseEnumerable(IEnumerable<Event> db)
        {
            return db.ToList().Select(MapDbToApiResponse).ToList();
        }
    }
}
