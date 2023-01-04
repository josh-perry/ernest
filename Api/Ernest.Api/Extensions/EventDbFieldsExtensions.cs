using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Extensions
{
    public static class EventDbFieldsExtensions
    {
        public static IEnumerable<EventField> GetAllEventFields(this Event @event)
        {
            return @event.BooleanFields
                .Concat<EventField>(@event.StringFields)
                .Concat(@event.DecimalFields)
                .Concat(@event.IntegerFields);
        }
    }
}