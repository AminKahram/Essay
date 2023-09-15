using Article.DomainModel.Models;
using Article.DomainModel.Query.Author;
using Article.Services.Services;
using Framework.Services.BaseServiceModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.DoaminRepository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ArticleContext db;
        public AuthorRepository(ArticleContext db)
        {
            this.db = db;
        }
        public OperationResult Add(Author Current)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                //if (ExistAuthor(Current.AuthorName))
                //{
                //    return op.Failed("There is already an author with this name");
                //}
                db.Authors.Add(Current);
                db.SaveChanges();
                return op.Succeeded(Current.AuthorID, "Author added successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to add " + ex.Message);
            }
        }

        public OperationResult Delete(DomainModel.Models.Author author)
        {
            OperationResult op = new OperationResult(author.AuthorID, OperationState.CurrentState.Delete);
            try
            {
                //var aut = db.Authors.FirstOrDefault(x => x.AuthorID == ID);

                //if (aut == null)
                //{
                //    return op.Failed("There isn't any author with this ID");
                //}
                //author.Articles.Clear();
                db.Authors.Remove(author);
                db.SaveChanges();
                return op.Succeeded("Author removed from database successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to remove "+ex.Message);
            }
        }
        public OperationResult Update(Author Current)
        {
            OperationResult op = new OperationResult(Current.AuthorID, OperationState.CurrentState.Update);
            try
            {
                //if (ExistAuthorIDForOtherAutherName(Current.AuthorID, Current.AuthorName))
                //{
                //    return op.Failed("There is already an author with this ID");
                //}
                db.Authors.Attach(Current);
                db.Entry<Author>(Current).State = EntityState.Modified;
                db.SaveChanges();
                return op.Succeeded("Author updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to update " + ex.Message);
            }
        }

    
        public Author Get(int ID)
        {
            return db.Authors.Include(x=>x.Articles).FirstOrDefault(x => x.AuthorID == ID);
        }

        public List<Author> GetAll()
        {
            return db.Authors.ToList();
        }

        //public List<AuthorListItemModel> Search(AuthorSearchModel sm, out int RecordCount)
        //{
        
        //    var q = db.Authors.Select(x => new AuthorListItemModel
        //    {
        //        AuthorID = x.AuthorID,
        //        AuthorName = x.AuthorName,
        //        ArticleCount = x.AuthorArticles.Count()
        //    });
        //    RecordCount = q.Count();
        //    sm.RecordCount = RecordCount;
        //    if (!string.IsNullOrEmpty(sm.AuthorName))
        //    {
        //        q = q.Where(x => x.AuthorName.StartsWith(sm.AuthorName));
        //    }
        //    return q.OrderByDescending(x => x.AuthorID).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize).ToList();
        //}

        public bool ExistAuthor(string AuthorName)
        {
            return db.Authors.Any(x => x.AuthorName == AuthorName);
        }

        public bool ExistAuthorIDForOtherAutherName(int AuthorID, string AuthorName)
        {
            return db.Authors.Any(x => x.AuthorID != AuthorID && x.AuthorName == AuthorName);
        }

      

        public List<DrpAuthorModel> GetAllForDrp()
        {
            var q = db.Authors;
            var m = q.Select(x => new DrpAuthorModel
            {
                AuthorID = x.AuthorID,
                AuthorName = x.AuthorName

            });
            return m.OrderByDescending(X => X.AuthorName).ToList();

        }

        public List<DrpAuthorModel> GetDrp(string AuthorName)
        {
            var q = from aut in db.Authors select aut;
            
            if (!string.IsNullOrEmpty(AuthorName))
            {
                 q  = q.Where(x => x.AuthorName.StartsWith(AuthorName));
            }
            return q.Select(x => new DrpAuthorModel
            {
                AuthorID = x.AuthorID,
                AuthorName = x.AuthorName
            }).OrderByDescending(x=>x.AuthorName).ToList();
            

        }

        public List<int> GetAuthorsForArticle(int ArticleID)
        {
            var authorIds = from aut in db.Authors where aut.Articles.Any(x => x.ArticleID == ArticleID) select aut.AuthorID;
            return authorIds.ToList();
        }

        public List<AuthorListItemModel> Search(AuthorSearchModel sm, out int RecordCount)
        {
            var authors = from aut in db.Authors select aut;
            if (sm.AuthorID != null)
            {
                authors = authors.Where(x => x.AuthorID==sm.AuthorID);
            }
           
            if (!string.IsNullOrEmpty(sm.AuthorName))
            {
                authors = authors.Where(x => x.AuthorName.StartsWith(sm.AuthorName));
            }
            RecordCount = authors.Count();
            return authors.Select(x => new AuthorListItemModel { AuthorID = x.AuthorID, AuthorName = x.AuthorName, ArticleCount = x.Articles.Count() }).OrderByDescending(x => x.AuthorName).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize).ToList();
        }
        public List<AuthorListItemForArticleModel> GetAuthorsListForArticle(int ArticleID)
        {
            var authors = from aut in db.Authors where aut.Articles.Any(x => x.ArticleID == ArticleID) select new AuthorListItemForArticleModel { AuthorID = aut.AuthorID, AuthorName = aut.AuthorName, ArticleID = ArticleID };
            return authors.ToList();
        }
        public DrpAuthorModel GetAuthorForUpdate(int AuthorID)
        {
            return db.Authors.Select(x => new DrpAuthorModel { AuthorID = x.AuthorID, AuthorName = x.AuthorName }).FirstOrDefault(x => x.AuthorID == AuthorID);
        }
    }
}
