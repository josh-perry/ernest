using System.Linq;
using System.Threading.Tasks;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;
using Ernest.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ernest.Api.Controllers
{
    [ApiController]
    [Route("eventField")]
    public class EventFieldController : Controller
    {
        private readonly IEventFieldRepository _eventFieldRepository;

        private readonly IEventTypeRepository _eventTypeRepository;

        private readonly IApiResponseMapper<EventStringFieldTemplate, EventFieldApiResponse> _stringFieldResponseMapper;

        private readonly IApiResponseMapper<EventDecimalFieldTemplate, EventFieldApiResponse> _decimalFieldResponseMapper;

        private readonly IApiResponseMapper<EventBooleanFieldTemplate, EventFieldApiResponse> _booleanFieldResponseMapper;

        private readonly IApiResponseMapper<EventIntegerFieldTemplate, EventFieldApiResponse> _integerFieldResponseMapper;

        public EventFieldController(
            IEventFieldRepository eventFieldRepository,
            IEventTypeRepository eventTypeRepository,
            IApiResponseMapper<EventStringFieldTemplate, EventFieldApiResponse> stringFieldResponseMapper,
            IApiResponseMapper<EventDecimalFieldTemplate, EventFieldApiResponse> decimalFieldResponseMapper,
            IApiResponseMapper<EventBooleanFieldTemplate, EventFieldApiResponse> booleanFieldResponseMapper,
            IApiResponseMapper<EventIntegerFieldTemplate, EventFieldApiResponse> integerFieldResponseMapper)
        {
            _eventFieldRepository = eventFieldRepository;
            _eventTypeRepository = eventTypeRepository;
            _stringFieldResponseMapper = stringFieldResponseMapper;
            _decimalFieldResponseMapper = decimalFieldResponseMapper;
            _booleanFieldResponseMapper = booleanFieldResponseMapper;
            _integerFieldResponseMapper = integerFieldResponseMapper;
        }

        /// <summary>
        ///     Get fields for event type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllForType(string eventType)
        {
            var type = _eventTypeRepository.GetByName(eventType).FirstOrDefault();

            if (type == null)
                return BadRequest($"Event type {eventType} not found");

            var booleans = _booleanFieldResponseMapper.MapDbToApiResponseEnumerable(_eventFieldRepository.GetBooleanTemplatesForEventType(type));
            var strings = _stringFieldResponseMapper.MapDbToApiResponseEnumerable(_eventFieldRepository.GetStringTemplatesForEventType(type));
            var integers = _integerFieldResponseMapper.MapDbToApiResponseEnumerable(_eventFieldRepository.GetIntegerTemplatesForEventType(type));
            var decimals = _decimalFieldResponseMapper.MapDbToApiResponseEnumerable(_eventFieldRepository.GetDecimalTemplatesForEventType(type));
            return Json(booleans.Union(strings).Union(integers).Union(decimals));
        }
    }
}
