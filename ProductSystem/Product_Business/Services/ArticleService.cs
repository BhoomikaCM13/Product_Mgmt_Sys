using Entity_Layer;
using Product_Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Business.Services
{
    public class ArticleService
    {
        IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository artRepository)
        {
            _articleRepository = artRepository;
        }
        public void AddArticle(Article article)
        {
            _articleRepository.AddArticle(article);
        }
        public Article GetArticle(Guid id)
        {
            return _articleRepository.GetArticle(id);
        }
    }
}
