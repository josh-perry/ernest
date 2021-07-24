using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ernest.Api.Models.Db
{
    public class EventType
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(120)]
        public string Title { get; set; }

        public ICollection<EventStringFieldTemplate> StringFields { get; set; } = new List<EventStringFieldTemplate>();

        public ICollection<EventBooleanFieldTemplate> BooleanFields { get; set; } = new List<EventBooleanFieldTemplate>();

        public ICollection<EventDecimalFieldTemplate> DecimalFields { get; set; } = new List<EventDecimalFieldTemplate>();

        public ICollection<EventIntegerFieldTemplate> IntegerFields { get; set; } = new List<EventIntegerFieldTemplate>();
    }

    public class EventFieldValues
    {
        public int ID { get; set; }

        public EventType EventType { get; set; }

        public ICollection<EventStringField> StringFields { get; set; }

        public ICollection<EventBooleanField> BooleanFields { get; set; }

        public ICollection<EventDecimalField> DecimalFields { get; set; }

        public ICollection<EventIntegerField> IntegerFields { get; set; }
    }
}
