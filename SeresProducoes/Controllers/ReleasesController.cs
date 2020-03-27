using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class ReleasesController : Controller
    {
        private readonly IReleaseRepository _releaseRepository;
        public ReleasesController(IReleaseRepository releaseRepository)
        {
            _releaseRepository = releaseRepository;
        }
        public IActionResult Releases()
        {
            return View(_releaseRepository.GetAllReleases());
        }
    }
}
