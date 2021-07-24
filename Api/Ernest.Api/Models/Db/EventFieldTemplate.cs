using System;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Db
{
    public abstract class EventFieldTemplate
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(120)]
        public string Title { get; set; }

        public int Priority { get; set; }

        public EventType EventType { get; set; }
    }

    public class EventStringFieldTemplate : EventFieldTemplate
    {
    }

    public class EventIntegerFieldTemplate : EventFieldTemplate
    {
    }

    public class EventBooleanFieldTemplate : EventFieldTemplate
    {
    }

    public class EventDecimalFieldTemplate : EventFieldTemplate
    {
    }
}
