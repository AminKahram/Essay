using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Article
{
    public class ArticleSearchListItemModelUtility
    {
        public static List<DomainModel.Query.Article.ArticleListItemModel> ToListItemModel(IQueryable<DomainModel.Models.Article> articles,IQueryable<DomainModel.Models.Author> authors,IQueryable<DomainModel.Models.Keyword> keywords,DomainModel.Query.Article.ArticleSearchModel sm,out int RecordCount)
        {
           
            if (!string.IsNullOrEmpty(sm.ArticleSubject))
            {
                articles = articles.Where(x => x.ArticleSubject.StartsWith(sm.ArticleSubject) );
            }
            if (sm.AuthorID != null && sm.AuthorID != 0)
            {

                articles = articles.Where(x => x.Authors.Any(y => y.AuthorID == sm.AuthorID));

            }

            RecordCount = articles.Count();

            var articleListItems = articles.Select(x => new DomainModel.Query.Article.ArticleListItemModel
            {
                ArticleID = x.ArticleID,
                ArticleSubject = x.ArticleSubject,
                PublicationDate = x.PublicationDate.Date,
                SmallDescription = x.SmallDescription,
                Size = x.Size,
                ArticlImageName=x.ArticleImageName,
                ArticlFileName=x.ArticleFileName,
                AuthorName = "",
                KeywordName=""
            }).OrderByDescending(x => x.AuthorName).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize).ToList();
            
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
