using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Ernest.Api.Models.Requests;
using Ernest.Api.Repositories.Interfaces;
using Ernest.Api.Services.Interfaces;

namespace Ernest.Api.Services
{
    public class EventValidator : IEventValidator
    {
        private readonly IEventTypeRepository _eventTypeRepository;

        private readonly IEventFieldRepository _eventFieldRepository;

        public EventValidator(IEventTypeRepository eventTypeRepository, IEventFieldRepository eventFieldRepository)
        {
            _eventTypeRepository = eventTypeRepository;
            _eventFieldRepository = eventFieldRepository;
        }

        public IEnumerable<ValidationResult> ValidateEventPost(EventPostRequest request)
        {
            var result = new List<ValidationResult>();

            if (!Validator.TryValidateObject(request, new ValidationContext(request), result))
                return result;

            var eventType = _eventTypeRepository.GetByName(request.EventType).FirstOrDefault();

            if (eventType == null)
            {
                result.Add(new ValidationResult($"Event type {request.EventType} not recognised!", new[]
                {
                    nameof(request.EventType)
                }));

                // No point validating the fields if we don't have an event type
                return result;
            }

            // Validate fields are present
            var allFields = _eventFieldRepository.GetAllTemplatesForEventType(eventType);

            foreach (var field in allFields)
            {
                if (!request.Fields.Keys.Contains(field.Title))
                    result.Add(new ValidationResult($"Field {field.Title} not accounted for in request"));
            }

            return result;
        }
    }
}
