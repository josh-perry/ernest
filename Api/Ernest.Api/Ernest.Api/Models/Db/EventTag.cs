using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Db
{
    public class EventTag
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(120)]
        public string Title { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
