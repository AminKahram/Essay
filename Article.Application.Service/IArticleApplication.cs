using Article.Application.Model.Models.AddEditModels.Article;
using Article.DomainModel.Query.Article;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Service
{
    public interface IArticleApplication 
    {
        OperationResult Add(ArticleAddEditModel Current, string AuthorID, string KeywordID );


        //OperationResult AssignKeywordArticleToArticle(int ArticleID, int KeywordID);

        //OperationResult AssignAuthorArticleToArticle(int ArticleID, int AuthorID);
        //OperationResult AssignAuthorArticleToArticle(ArticleAddEditModel current, string AuthorID);
        //KeywordArticle
        //OperationResult AssignKeywordArticleToArticle(DomainModel.Models.Article article, string KeywordID);
        //OperationResult UpdateKeywordArticleFromArticle(DomainModel.Models.Article article, string KeywordID);
        OperationResult Delete(int ID);


        //OperationResult DeleteKeywordArticleFromArticle(int ArticleID, int KeywordID);

        
        OperationResult DeleteKeywordArticleFromArticle(int ArticleID, int KeywordID);
        OperationResult DeleteAuthorArticleFromArticle(int ArticleID, int AuthorID);
        bool ExistAArticleIDForOtherArticleName(int ArticleID, string ArticleName);


        bool ExistArticle(string ArticleName);


        ArticleAddEditModel UpdateGet(int ID);
         
        DomainModel.Models.Article Get(int ID);
        List<DomainModel.Models.Article> GetAll();
        //List<ArticleListItemForClientModel> GetClientArticles(int CategoryID);
        List<ArticleListItemForAuthorModel> GetAuthorsListForArticle(int AuthorID);
        List<ArticleListItemForClientModel> GetClientArticles(ArticleSearchModel sm, out int RecordCount);
        ArticleClientItemModel GetClientArticle(int ID);
        List<ArticleListItemModel> Search(ArticleSearchModel sm, out int RecordCount);


        OperationResult Update(ArticleAddEditModel Current, string AuthorID, string KeywordID);


        //OperationResult UpdateKeywordArticleFromArticle(int ArticleID, int KeywordID);

    }
}
