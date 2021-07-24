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

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllEventTypes()
        {
            var eventTypes = _eventTypeRepository.GetAll();
            return Json(_eventTypeResponseMapper.MapDbToApiResponseEnumerable(eventTypes.ToList()));
        }
    }
}
