using Article.Application.Implementation.ApplicationUtilities.Author;
using Article.Application.Model.Models.AddEditModels.Author;
using Article.Application.Service;
using Article.DomainModel.Models;
using Article.DomainModel.Query.Author;
using Article.Services.Services;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Article.Application.Implementation
{
    public class AuthorApplication : IAuthorApplication
    {
        private readonly IAuthorRepository repo;
        private readonly IArticleApplication articleApplication;
        public AuthorApplication(IAuthorRepository repo, IArticleApplication articleApplication)
        {
            this.repo = repo;
            this.articleApplication = articleApplication;
        }
        private Author ToDBModel(AuthorAddEditModel Current)
        {
            return new Author
            {
                AuthorID=Current.AuthorID,
                AuthorName = Current.AuthorName
            };
        }
        private AuthorAddEditModel ToAddEditModel(Author Current)
        {
            return new AuthorAddEditModel
            {
                AuthorID=Current.AuthorID,
                AuthorName = Current.AuthorName
            };
        }
        public OperationResult Add(AuthorAddEditModel Current)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                if (ExistAuthor(Current.AuthorName))
                {
                    return op.Failed("There is already an author with this name");
                }
                return repo.Add(ToDBModel(Current));
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to add " + ex.Message);
            }
               
        }

        public OperationResult Delete(int ID)
        {
            OperationResult op = new OperationResult(ID, OperationState.CurrentState.Delete);
            try
            {
                var aut = Get(ID);

                if (aut == null)
                {
                    return op.Failed("There isn't any author with this ID");
                }

                var articles = aut.Articles.Select(x => x.ArticleID).ToArray();
                for (int i = 0; i < articles.Length; i++)
                {
                    op = articleApplication.Delete(articles[i]);
                }
                //repo.Delete(aut);
                //foreach (var item in aut.Articles)
                //{
                //    op= articleApplication.Delete(item.ArticleID);
                //}
                return repo.Delete(aut);
            }
            catch (Exception ex )
            {
                return op.Failed("Author failedto remove " + ex.Message);
            }
        }

        public bool ExistAuthor(string AuthorName)
        {
            return repo.ExistAuthor(AuthorName);
        }

        public bool ExistAuthorIDForOtherAutherName(int AuthorID, string AuthorName)
        {
            return repo.ExistAuthorIDForOtherAutherName(AuthorID, AuthorName);
        }
        
        //public AuthorAddEditModel GetAddEdit(int ID)
        //{
        //    return ToAddEditModel(repo.Get(ID));
        //}

        public List<Author> GetAll()
        {
            return repo.GetAll();
        }

        public List<AuthorListItemModel> Search(AuthorSearchModel sm, out int RecordCount)
        {
            if (sm == null)
            {
                sm = new AuthorSearchModel { PageIndex = 0, PageSize = 10 };
            }
            if (sm.PageSize == 0)
            {
                sm.PageSize = 10;
            }
            return repo.Search(sm, out RecordCount);
        }

        public OperationResult Update(AuthorAddEditModel Current)
        {
            OperationResult op = new OperationResult(Current.AuthorID, OperationState.CurrentState.Update);
            try
            {
                if (ExistAuthorIDForOtherAutherName(Current.AuthorID, Current.AuthorName))
                {
                    return op.Failed("There is already an author with this ID");
                }
                return repo.Update(ToDBModel(Current));
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to remove " + ex.Message);
            }
              
        }

        public List<DrpAuthorModel> GetAllForDrp()
        {
            return repo.GetAllForDrp();
        }

        public List<DrpAuthorModel> GetDrp(string AuthorName)
        {
            return repo.GetDrp(AuthorName);
        }

        public List<int> GetAuthorsForArticle(int ArticleID)
        {
            return repo.GetAuthorsForArticle(ArticleID);
        }
        public List<AuthorListItemForArticleModel> GetAuthorsListForArticle(int ArticleID)
        {
            return repo.GetAuthorsListForArticle(ArticleID);
        }
 
        public Author GetAuthorForArticle(int ID)
        {
            return repo.Get(ID);
        }

        public Author Get(int ID)
        {
            return repo.Get(ID);
        }

        public AuthorAddEditModel GetAuthorForUpdate(int AuthorID)
        {
            return AuthorDrpToAddEditModelUtility.ToAddEdit(repo.GetAuthorForUpdate(AuthorID));
        }
    }
}
