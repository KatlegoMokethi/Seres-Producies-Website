using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AppDbContext _appDbContext;
        public ArticleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Article> GetAllArticles() => _appDbContext.Articles.OrderBy(a => a.Date);
    }
}
