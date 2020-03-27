using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _appDbContext;
        public EventRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Event> GetAllEvents() => _appDbContext.Events.OrderBy(e => e.Id);
    }
}
