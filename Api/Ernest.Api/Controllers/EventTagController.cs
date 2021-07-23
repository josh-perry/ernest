using Ernest.Api.Data;
using Ernest.Api.Mappers;
using Ernest.Api.Models.Db;
using Ernest.Api.Models.Requests;
using Ernest.Api.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Ernest.Api.Controllers
{

    [ApiController]
    [Route("eventTag")]
    public class EventTagController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IApiResponseMapper<EventTag, EventTagApiResponse> _eventTagResponseMapper;

        public EventTagController(
            ApplicationDbContext applicationDbContext,
            IApiResponseMapper<EventTag, EventTagApiResponse> eventTagResponseMapper)
        {
            _applicationDbContext = applicationDbContext;
            _eventTagResponseMapper = eventTagResponseMapper;
        }

        /// <summary>
        ///     Get all event tags
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var eventTags = _applicationDbContext.EventTags;
            return Json(_eventTagResponseMapper.MapDbToApiResponseEnumerable(eventTags));
        }

        /// <summary>
        ///     Add a new event tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] EventTagsPostRequest request)
        {
            var newTag = _applicationDbContext.Add(new EventTag
            {
                Title = request.Title
            });

            _applicationDbContext.SaveChanges();
            return Json(_eventTagResponseMapper.MapDbToApiResponse(newTag.Entity));
        }
    }
}
