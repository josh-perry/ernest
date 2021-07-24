using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Requests
{
    public class EventTagsPostRequest
    {
        [Required]
        [MaxLength(120)]
        public string Title { get; set; }
    }
}
