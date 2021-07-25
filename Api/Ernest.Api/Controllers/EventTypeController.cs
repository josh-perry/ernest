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
    [Route("eventType")]
    public class EventTypeController : Controller
    {
        private readonly IEventTypeRepository _eventTypeRepository;

        private readonly IApiResponseMapper<EventType, EventTypeApiResponse> _eventTypeResponseMapper;

        public EventTypeController(
            IEventTypeRepository eventTypeRepository,
            IApiResponseMapper<EventType, EventTypeApiResponse> eventTypeResponseMapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _eventTypeResponseMapper = eventTypeResponseMapper;
        }

        /// <summary>
        ///     Get all event types
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllEventTypes()
        {
            var eventTypes = _eventTypeRepository.GetAll();
            return Json(_eventTypeResponseMapper.MapDbToApiResponseEnumerable(eventTypes.ToList()));
        }

        /// <summary>
        ///     Get event type by name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{eventTypeName}")]
        public async Task<IActionResult> GetEventTypeByName(string eventTypeName)
        {
            var eventTypes = _eventTypeRepository.GetByName(eventTypeName).FirstOrDefault();

            if (eventTypes == null)
                return NotFound($"Event type '{eventTypeName}' not found");

            return Json(_eventTypeResponseMapper.MapDbToApiResponse(eventTypes));
        }
    }
}
