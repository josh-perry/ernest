using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Db
{
    public class Event
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(120)]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public EventType EventType { get; set; }

        public ICollection<EventTag> EventTags { get; set; }

        //public ICollection<EventFieldValues> FieldValues { get; set; }
    }
}
