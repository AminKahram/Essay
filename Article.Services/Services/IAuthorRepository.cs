using Article.DomainModel.Models;
using Article.DomainModel.Query.Author;
using Framework.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Services.Services
{
    public interface IAuthorRepository:IBaseRepositorySearchable<Author,int,AuthorSearchModel,AuthorListItemModel>
    {
        bool ExistAuthor(string AuthorName);
        bool ExistAuthorIDForOtherAutherName(int AuthorID, string AuthorName);
        List<DrpAuthorModel> GetAllForDrp();
        List<DrpAuthorModel> GetDrp(string AuthorName);
        List<AuthorListItemForArticleModel> GetAuthorsListForArticle(int ArticleID);

        List<int> GetAuthorsForArticle(int ArticleID);
        DrpAuthorModel GetAuthorForUpdate(int AuthorID);
    }
}
