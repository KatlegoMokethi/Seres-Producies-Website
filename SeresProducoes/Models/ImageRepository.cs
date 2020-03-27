using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _appDbContext;
        public ImageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Image> GetImages() => _appDbContext.Images.OrderBy(i => i.Id);
    }
}
