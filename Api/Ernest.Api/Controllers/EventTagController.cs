using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Requests;
using Ernest.Api.Models.Responses;
using Ernest.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ernest.Api.Controllers
{

    [ApiController]
    [Route("eventTag")]
    public class EventTagController : Controller
    {
        private readonly IApiResponseMapper<EventTag, EventTagApiResponse> _eventTagResponseMapper;

        private readonly IEventTagsRepository _eventTagsRepository;

        public EventTagController(
            IApiResponseMapper<EventTag, EventTagApiResponse> eventTagResponseMapper,
            IEventTagsRepository eventTagsRepository)
        {
            _eventTagResponseMapper = eventTagResponseMapper;
            _eventTagsRepository = eventTagsRepository;
        }

        /// <summary>
        ///     Get all event tags
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IActionResult GetAllEventTags()
        {
            return Json(_eventTagResponseMapper.MapDbToApiResponseEnumerable(_eventTagsRepository.GetAll()));
        }

        /// <summary>
        ///     Add a new event tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> PostNewEventTag([FromBody] EventTagsPostRequest request)
        {
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(request, new ValidationContext(request), validationResults))
                return BadRequest(validationResults);

            var newTag = new EventTag
            {
                Title = request.Title
            };

            await _eventTagsRepository.AddTagAsync(newTag);
            return Json(_eventTagResponseMapper.MapDbToApiResponse(newTag));
        }
    }
}
