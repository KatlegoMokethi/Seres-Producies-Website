using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _appDbContext;
        public ArtistRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Artist> GetAllArtists() => _appDbContext.Artists.OrderBy(a => a.Id);

        public Artist GetArtistById(int artistId) => _appDbContext.Artists.FirstOrDefault(a => a.Id == artistId);
    }
}
