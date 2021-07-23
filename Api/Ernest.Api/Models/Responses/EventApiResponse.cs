using System;
using System.Collections.Generic;

namespace Ernest.Api.Models.Responses
{
    public class EventApiResponse
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public IEnumerable<EventTagApiResponse> EventTags { get; set; }
    }
}
