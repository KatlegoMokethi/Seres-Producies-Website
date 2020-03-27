using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class ReleaseRepository : IReleaseRepository
    {
        private readonly AppDbContext _appDbContext;
        public ReleaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Release> GetAllReleases() => _appDbContext.Releases.OrderByDescending(r => r.Id);
    }
}
