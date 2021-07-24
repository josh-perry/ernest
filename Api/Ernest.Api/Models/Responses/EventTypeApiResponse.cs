using System.Collections.Generic;

namespace Ernest.Api.Models.Responses
{
    public class EventTypeApiResponse
    {
        public string Title { get; set; }

        public List<string> Fields { get; set; }
    }
}
