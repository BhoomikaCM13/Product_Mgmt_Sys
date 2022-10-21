using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        ProductDbContext _adb;

        public ArticleRepository(ProductDbContext adb)
        {
            _adb = adb;
        }

        public void AddArticle(Article article)
        {
           
            Guid aId = Guid.NewGuid();
            article.ArticleId = aId;
            _adb.Articles.Add(article);
            _adb.SaveChanges();
        }

        public Article GetArticle(Guid id)
        {
            return _adb.Articles.Find(id);
        }
    }

}
