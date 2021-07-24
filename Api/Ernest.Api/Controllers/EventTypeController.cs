using System.Linq;
using System.Threading.Tasks;
using Ernest.Api.Data;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ernest.Api.Controllers
{
    [ApiController]
    [Route("eventType")]
    public class EventTypeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly IApiResponseMapper<EventType, EventTypeApiResponse> _eventTypeResponseMapper;

        public EventTypeController(
            ApplicationDbContext dbContext,
            IApiResponseMapper<EventType, EventTypeApiResponse> eventTypeResponseMapper)
        {
            _dbContext = dbContext;
            _eventTypeResponseMapper = eventTypeResponseMapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllEventTypes()
        {
            var r = _dbContext.EventTypes
                .Include(x => x.EventTypeFields)
                    .ThenInclude(x => x.BooleanFields)
                .Include(x => x.EventTypeFields)
                    .ThenInclude(x => x.StringFields)
                .Include(x => x.EventTypeFields)
                    .ThenInclude(x => x.IntegerFields)
                .Include(x => x.EventTypeFields)
                    .ThenInclude(x => x.DecimalFields);

            return Json(_eventTypeResponseMapper.MapDbToApiResponseEnumerable(r.ToList()));
        }
    }
}
