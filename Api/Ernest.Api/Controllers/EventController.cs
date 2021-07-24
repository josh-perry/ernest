using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ernest.Api.Data;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Requests;
using Ernest.Api.Models.Responses;
using Ernest.Api.Repositories.Interfaces;
using Ernest.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ernest.Api.Controllers
{
    [ApiController]
    [Route("event")]
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IApiResponseMapper<Event, EventApiResponse> _eventResponseMapper;

        private readonly IEventTagsRepository _eventTagsRepository;

        private readonly IEventTypeRepository _eventTypeRepository;

        private readonly IEventValidator _eventValidator;

        private readonly ILogger<EventController> _logger;

        public EventController(
            ApplicationDbContext applicationDbContext,
            IApiResponseMapper<Event, EventApiResponse> eventResponseMapper,
            IEventTagsRepository eventTagsRepository,
            IEventTypeRepository eventTypeRepository,
            IEventValidator eventValidator,
            ILogger<EventController> logger)
        {
            _applicationDbContext = applicationDbContext;
            _eventResponseMapper = eventResponseMapper;
            _eventTagsRepository = eventTagsRepository;
            _eventTypeRepository = eventTypeRepository;
            _eventValidator = eventValidator;
            _logger = logger;
        }

        /// <summary>
        ///     Get all events
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = _applicationDbContext.Events.Include(x => x.EventTags).Include(x => x.EventType);
            return Json(_eventResponseMapper.MapDbToApiResponseEnumerable(events));
        }

        /// <summary>
        ///     Add a new event
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> PostNewEvent([FromBody] EventPostRequest request)
        {
            var validationResults = _eventValidator.ValidateEventPost(request);
            if (validationResults.Any())
                return BadRequest(validationResults);

            var eventType = _eventTypeRepository.GetByName(request.EventType).FirstOrDefault();

            var newEvent = new Event
            {
                Description = request.Description,
                Title = request.Title,
                DateTime = DateTime.UtcNow,
                EventTags = _eventTagsRepository.GetByName(request.EventTags).ToList(),
                EventType = eventType
            };

            await _applicationDbContext.AddAsync(newEvent);
            await _applicationDbContext.SaveChangesAsync();

            _logger.LogInformation($"Added new event: {newEvent.ID}");
            return Json(_eventResponseMapper.MapDbToApiResponse(newEvent));
        }
    }
}
