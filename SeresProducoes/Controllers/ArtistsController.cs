using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class ArtistsController : Controller
    {
        private readonly IArtistRepository _artistRepository;
        public ArtistsController(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public IActionResult Artists()
        {
            return View(_artistRepository.GetAllArtists());
        }
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            var artist = _artistRepository.GetArtistById(id);
            if (artist == null)
                return NotFound();

            return View(artist);
        }
    }
}
//public IActionResult Index()
//{
//    return View(_pieRepository.GetAllPies().OrderBy(p => p.Name));
//}
//public IActionResult Details(int id)
//{
//    var pie = _pieRepository.GetPieById(id);
//    if (pie == null)
//        return NotFound();

//    return View(pie);
//}