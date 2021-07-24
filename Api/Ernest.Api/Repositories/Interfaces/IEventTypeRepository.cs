using System.Collections.Generic;
using System.Linq;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Repositories.Interfaces
{
    public interface IEventTypeRepository
    {
        IQueryable<EventType> GetAll();

        IQueryable<EventType> GetByName(string name);

        IEnumerable<EventType> GetByName(IEnumerable<string> names);
    }
}
