using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class NewsController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        public NewsController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
       public IActionResult News()
        {
            return View(_articleRepository.GetAllArticles());
        }
    }
}
