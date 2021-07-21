using System.Linq;
using Ernest.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ernest.Api.Controllers
{
    [ApiController]
    [Route("eventTags")]
    public class EventTagsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EventTagsController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [Route("/")]
        public IActionResult GetAll()
        {
            return Json(_applicationDbContext.EventTags.ToList());
        }
    }
}
