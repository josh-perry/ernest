using System.Collections.Generic;
using Ernest.Api.Models.Db;

namespace Ernest.Api.Repositories.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAll();

        Event Add(Event e);
    }
}
