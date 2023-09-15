using Article.DomainModel.Models;
using Article.DomainModel.Query.Article;
using Framework.Services.BaseServiceModel;
using Framework.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Services.Services
{
    public interface IArticleRepository
    {
        OperationResult Add(Article.DomainModel.Models.Article Current, List<int> authorID, List<int> KeywordID);
        OperationResult Delete(Article.DomainModel.Models.Article article);
        OperationResult Update(DomainModel.Models.Article Current, List<int> authorID, List<int> KeywordID);
        List<ArticleListItemModel> Search(ArticleSearchModel sm, out int RecordCount);
        List<ArticleListItemForClientModel> GetClientArticles(ArticleSearchModel sm, out int RecordCount);
        ArticleClientItemModel GetClientArticle(int ID);
        DomainModel.Models.Article Get(int ID);
        List<DomainModel.Models.Article> GetAll();
        List<ArticleListItemForAuthorModel> GetAuthorsListForArticle(int AuthorID);
        ArticleUpdateItemModel UpdateGet(int ID);
        //Article.DomainModel.Models.Article Get(int ID);

        bool ExistArticle(string ArticleName);
        bool ExistAArticleIDForOtherArticleName(int ArticleID, string ArticleName);
        //KeywordArticle
        OperationResult AssignKeywordArticleToArticle(DomainModel.Models.Article article, List<int> KeywordID);
        OperationResult UpdateKeywordArticleFromArticle(DomainModel.Models.Article article, List<int> KeywordID);
        OperationResult DeleteKeywordArticleFromArticle(DomainModel.Models.Article article,Keyword keyword);
        //AuthorArticle
        //OperationResult AssignAuthorArticleToArticle(int ArticleID, int AuthorID);
        //OperationResult UpdateAuthorArticleFromArticle(int ArticleID, List<int> authorID);
        OperationResult UpdateAuthorArticleFromArticle(DomainModel.Models.Article article, List<int> authorID);
        //OperationResult DeleteAuthorArticleFromArticle(int ArticleID, int AuthorID);
        //OperationResult AssignAuthorArticleToArticle(Article.DomainModel.Models.Article article, Author author);
        OperationResult AssignAuthorArticleToArticle(DomainModel.Models.Article article, List<int> authorID);
        OperationResult DeleteAuthorArticleFromArticle(DomainModel.Models.Article article, Author author);

    }
}
