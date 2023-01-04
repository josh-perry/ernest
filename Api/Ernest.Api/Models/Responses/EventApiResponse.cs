using System;
using System.Collections.Generic;

namespace Ernest.Api.Models.Responses
{
    public class EventApiResponse
    {
        public int ID { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public IEnumerable<EventTagApiResponse> EventTags { get; set; }

        public string EventType { get; set; }
        
        public IEnumerable<EventFieldApiResponse> EventFields { get; set; }
    }
}
