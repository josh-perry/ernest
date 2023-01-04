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

        private readonly IApiResponseMapper<EventFieldTemplate, EventFieldTemplateApiResponse> _fieldResponseMapper;

        public EventFieldController(
            IEventFieldRepository eventFieldRepository,
            IEventTypeRepository eventTypeRepository,
            IApiResponseMapper<EventFieldTemplate, EventFieldTemplateApiResponse> fieldResponseMapper)
        {
            _eventFieldRepository = eventFieldRepository;
            _eventTypeRepository = eventTypeRepository;
            _fieldResponseMapper = fieldResponseMapper;
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

            var fields = _eventFieldRepository.GetAllTemplatesForEventType(type);
            return Json(_fieldResponseMapper.MapDbToApiResponseEnumerable(fields));
        }
    }
}
