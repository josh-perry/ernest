using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Repositories.Interfaces
{
    public interface IEventTagsRepository
    {
        IQueryable<EventTag> GetAll();

        IQueryable<EventTag> GetByName(string name);

        IEnumerable<EventTag> GetByName(IEnumerable<string> names);

        Task<bool> AddTagAsync(EventTag tag);
    }
}
