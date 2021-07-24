using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Requests
{
    public class EventPostRequest
    {
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string[] EventTags { get; set; }

        [Required]
        public string EventType { get; set; }

        public Dictionary<string, object> Fields { get; set; }
    }
}
