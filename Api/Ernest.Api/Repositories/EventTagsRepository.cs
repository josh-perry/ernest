using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ernest.Api.Data;
using Ernest.Api.Models.Db;
using Ernest.Api.Repositories.Interfaces;

namespace Ernest.Api.Repositories
{
    public class EventTagsRepository : IEventTagsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EventTagsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<EventTag> GetAll()
        {
            return _dbContext.EventTags;
        }

        public IQueryable<EventTag> GetByName(string name)
        {
            return _dbContext.EventTags.Where(x => x.Title == name);
        }

        public IEnumerable<EventTag> GetByName(IEnumerable<string> names)
        {
            return _dbContext.EventTags.Where(x => names.Contains(x.Title));
        }

        public async Task<bool> AddTagAsync(EventTag tag)
        {
            _dbContext.Add(tag);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
