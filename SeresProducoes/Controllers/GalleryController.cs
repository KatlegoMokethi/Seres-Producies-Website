using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class GalleryController : Controller
    {
        private readonly IImageRepository _imageRepository;
        public GalleryController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public IActionResult Gallery()
        {
            return View(_imageRepository.GetImages());
        }
    }
}
