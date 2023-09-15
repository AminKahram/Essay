using Article.DomainModel.Query.Article;
using Article.DomainModel.Query.Author;
using Article.DomainModel.Query.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Article
{
    public class ArticleUpdateItemModelUtility
    {
        public static ArticleUpdateItemModel ToArticleUpdateItemModel(DomainModel.Models.Article article,IQueryable<DrpAuthorModel> authors, IQueryable<DrpKeywordModel> keywords,int parentID)
        {
            var toupdatemodel = new ArticleUpdateItemModel 
            {
                ArticleID = article.ArticleID,
                ArticleFile = article.ArticleFile,
                ArticleImage = article.ArticleImage,
                ArticleImageName=article.ArticleImageName,
                ArticleFileName=article.ArticleFileName,
                ArticleSubject = article.ArticleSubject,
                CategoryID = article.CategoryID,
                ParentID=parentID,
                Description = article.Description,
                PublicationDate = article.PublicationDate,
                Size = article.Size,
                SmallDescription = article.SmallDescription,

            };
            var AuthorName = "";
            var AuthorID = "";
            foreach (var items in authors)
            {
                AuthorName = AuthorName + items.AuthorName + ",";
                AuthorID = AuthorID + items.AuthorID + ",";
            }
            var KeywordID = "";
            var KeywordName = "";
            foreach (var items in keywords)
            {
                KeywordName = KeywordName + items.KeywordName + ",";
                KeywordID = KeywordID + items.KeywordID + ",";
            }
            toupdatemodel.KeywordID = KeywordID;
            toupdatemodel.KeywordName = KeywordName;
            toupdatemodel.AuthorID = AuthorID;
            toupdatemodel.AuthorName = AuthorName;
            return toupdatemodel;
        }
    }
}
