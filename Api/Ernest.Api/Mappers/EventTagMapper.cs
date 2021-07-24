using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;

namespace Ernest.Api.Mappers
{
    public class EventTagMapper : IApiResponseMapper<EventTag, EventTagApiResponse>
    {
        public EventTagApiResponse MapDbToApiResponse(EventTag db)
        {
            return new EventTagApiResponse
            {
                Title = db.Title
            };
        }

        public IEnumerable<EventTagApiResponse> MapDbToApiResponseEnumerable(IEnumerable<EventTag> db)
        {
            return db.Select(MapDbToApiResponse).ToList();
        }
    }
}
