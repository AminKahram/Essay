using Article.Application.Model.Models.AddEditModels.Author;
using Article.DomainModel.Models;
using Article.DomainModel.Query.Author;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Service
{
    public interface IAuthorApplication
    {
        OperationResult Add(AuthorAddEditModel Current);
        OperationResult Delete(int ID);
        OperationResult Update(AuthorAddEditModel Current);
        Author GetAuthorForArticle(int ID);
        //AuthorAddEditModel GetAddEdit(int ID);
        Author Get(int ID);
        List<Author> GetAll();
        List<AuthorListItemModel> Search(AuthorSearchModel sm, out int RecordCount);
        List<AuthorListItemForArticleModel> GetAuthorsListForArticle(int ArticleID);
        bool ExistAuthor(string AuthorName);
        bool ExistAuthorIDForOtherAutherName(int AuthorID, string AuthorName);
        List<DrpAuthorModel> GetAllForDrp();
        public List<DrpAuthorModel> GetDrp(string AuthorName);
        List<int> GetAuthorsForArticle(int ArticleID);
        //List<AuthorAddEditModel> GetAuthorsFor
        AuthorAddEditModel GetAuthorForUpdate(int AuthorID);

    }
}
