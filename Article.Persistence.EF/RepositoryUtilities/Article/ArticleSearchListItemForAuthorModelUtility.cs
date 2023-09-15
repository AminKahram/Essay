using Article.DomainModel.Query.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Article
{
    public class ArticleSearchListItemForAuthorModelUtility
    {
        public static List<ArticleListItemForAuthorModel> ToListItem(IQueryable<DomainModel.Models.Article> articles, IQueryable<DomainModel.Models.Author> authors, IQueryable<DomainModel.Models.Keyword> keywords,int AuthorID)
        {
            //RecordCount = articles.Count();
            
            var articleListItems = articles.Select(x => new ArticleListItemForAuthorModel
            {
                ArticleID = x.ArticleID,
                ArticleSubject = x.ArticleSubject,
                PublicationDate = x.PublicationDate.Date,
                SmallDescription = x.SmallDescription,
                Size = x.Size,
                ArticlImageName = x.ArticleImageName,
                ArticlFileName=x.ArticleFileName,
                AuthorName = "",
                KeywordName = ""
                ,AuthorID=AuthorID
            }).ToList();
            //.OrderByDescending(x => x.AuthorName).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize)
            foreach (var item in articleListItems)
            {
                var AuthorName = "";
                var KeywordName = "";
                //var articleauthors = from aut in authors where aut.Articles.ArticleID == item.ArticleID select aut.Author.AuthorName;

                var articleauthors = from aut in authors where aut.Articles.Any(x => x.ArticleID == item.ArticleID) select aut;
                var articlekeywords = from key in keywords where key.Articles.Any(x => x.ArticleID == item.ArticleID) select key;


                foreach (var items in articleauthors)
                {
                    AuthorName = AuthorName + items.AuthorName + ",";
                }
                foreach (var items in articlekeywords)
                {
                    KeywordName = KeywordName + items.KeywordName + ",";
                }
                item.AuthorName = AuthorName;
                item.KeywordName = KeywordName;
            }
            return articleListItems;
        }
    }
}
