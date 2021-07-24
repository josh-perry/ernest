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

        public ICollection<EventStringField> StringFields { get; set; }

        public ICollection<EventBooleanField> BooleanFields { get; set; }

        public ICollection<EventDecimalField> DecimalFields { get; set; }

        public ICollection<EventIntegerField> IntegerFields { get; set; }
    }
}
