using Article.DomainModel.Query.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Article
{
    public class ArticleSearchListForClientUtility
    {
        public static List<ArticleListItemForClientModel> ToClientList(IQueryable<DomainModel.Models.Article> articles, IQueryable<DomainModel.Models.Author> authors, ArticleSearchModel sm, out int RecordCount)
        {
            if (!string.IsNullOrEmpty(sm.ArticleSubject))
            {
                articles = articles.Where(x => x.ArticleSubject.StartsWith(sm.ArticleSubject));
            }
            if (sm.CategoryID != null)
            {
                articles = articles.Where(x => x.CategoryID == sm.CategoryID);
            }
            int recordc = articles.Count();
            var articleListItems = articles.Select(x => new DomainModel.Query.Article.ArticleListItemForClientModel
            {
                ArticleID = x.ArticleID,
                ArticleSubject = x.ArticleSubject,
                ArticlImageName = x.ArticleImageName,
                ArticlFileName=x.ArticleFileName,
                AuthorName = "",
            }).OrderByDescending(x => x.ArticleSubject).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize).ToList();
            
            RecordCount = articles.Count();
            foreach (var item in articleListItems)
            {
                var AuthorName = "";
                var AuthorID = "";
                //var KeywordName = "";
                //var articleauthors = from aut in authors where aut.Articles.ArticleID == item.ArticleID select aut.Author.AuthorName;

                var articleauthors = from aut in authors where aut.Articles.Any(x => x.ArticleID == item.ArticleID) select aut;
                //var articlekeywords = from key in keywords where key.Articles.Any(x => x.ArticleID == item.ArticleID) select key;


                foreach (var items in articleauthors)
                {
                    AuthorName = AuthorName + items.AuthorName + ",";
                    AuthorID = AuthorID + items.AuthorID + ",";
                }
                //foreach (var items in articlekeywords)
                //{
                //    KeywordName = KeywordName + items.KeywordName + ",";
                //}
                item.AuthorName = AuthorName;
                item.AuthorID = AuthorID;
                item.ArticleRecordCount = recordc;
                //item.KeywordName = KeywordName;
            };
            return articleListItems;
        }
        public static ArticleClientItemModel ToClientItem(DomainModel.Models.Article article, IQueryable<DomainModel.Models.Author> authors)
        {

            //var articleListItems = articles.Select(x => new DomainModel.Query.Article.ArticleListItemForClientModel
            //{
            //    ArticleID = x.ArticleID,
            //    ArticleSubject = x.ArticleSubject,
            //    ArticlImageName = x.ArticleImageName,
            //    AuthorName = "",
            //});
        
            var articleitem = new ArticleClientItemModel
            {
                ArticleID = article.ArticleID,
                ArticleFileName = article.ArticleFileName,
                ArticleImageName = article.ArticleImageName,
                ArticleSubject = article.ArticleSubject,
                Description = article.Description,
                PublicationDate = article.PublicationDate,
                Size = article.Size,
                SmallDescription = article.SmallDescription
            };
            var AuthorName = "";
            var AuthorID = "";

            var articleauthors = from aut in authors where aut.Articles.Any(x => x.ArticleID == articleitem.ArticleID) select aut;
            foreach (var items in articleauthors)
            {
                AuthorName = AuthorName + items.AuthorName + ",";
                AuthorID = AuthorID + items.AuthorID + ",";
            }


            //foreach (var items in articlekeywords)
            //{
            //    KeywordName = KeywordName + items.KeywordName + ",";
            //}
            articleitem.AuthorName = AuthorName;
            articleitem.AuthorID = AuthorID;
                //item.KeywordName = KeywordName;
            return articleitem;
        }
    }
}
