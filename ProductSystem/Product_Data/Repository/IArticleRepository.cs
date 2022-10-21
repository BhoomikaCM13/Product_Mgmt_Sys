using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Data.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        Article GetArticle(Guid id);
    }
}
