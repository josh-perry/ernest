using System;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Db
{
    public abstract class EventField
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(120)]
        public string Title { get; set; }

        public int Priority { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime LastEditedDateTime { get; set; }

        public EventType EventType { get; set; }
    }

    public class EventStringField : EventField
    {
        public string String { get; set; }
    }

    public class EventIntegerField : EventField
    {
        public int Integer { get; set; }
    }

    public class EventBooleanField : EventField
    {
        public bool Boolean { get; set; }
    }

    public class EventDecimalField : EventField
    {
        public decimal Decimal { get; set; }
    }
}
