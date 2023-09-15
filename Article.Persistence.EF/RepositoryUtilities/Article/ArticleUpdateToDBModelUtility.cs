using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Article
{
    public class ArticleUpdateToDBModelUtility
    {
        public static DomainModel.Models.Article ToDBModel(DomainModel.Models.Article searchedarticle, DomainModel.Models.Article updatearticle)
        {
            return new DomainModel.Models.Article
            {
                ArticleFile = updatearticle.ArticleFile,
                ArticleImage = updatearticle.ArticleImage,
                ArticleImageName = updatearticle.ArticleImageName,
                ArticleFileName=updatearticle.ArticleFileName,
                
                ArticleSubject = updatearticle.ArticleSubject,
                CategoryID = updatearticle.CategoryID,
                Description = updatearticle.Description,
                PublicationDate = updatearticle.PublicationDate,
                Size = updatearticle.Size,
                SmallDescription = updatearticle.SmallDescription,
                ArticleID = updatearticle.ArticleID,
                Authors = searchedarticle.Authors,
                Keywords = searchedarticle.Keywords,
                Category = searchedarticle.Category

            };
        }
    }
}
