using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists();
        Artist GetArtistById(int artistId);
    }
}
