using Article.DomainModel.Models;
using Article.DomainModel.Query.Author;
using Article.DomainModel.Query.Keyword;
using Article.Persistence.EF.RepositoryUtilities.Keyword;
using Article.Services.Services;
using Framework.Services.BaseServiceModel;
using Framework.Services.BaseServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.DoaminRepository
{
    public class KeywordRepository : IKeywordRepository
    {
        private readonly ArticleContext db;
        public KeywordRepository(ArticleContext db)
        {
            this.db = db;
        }
     
        public OperationResult Add(Keyword Current)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                if (ExistKeyword(Current.KeywordName))
                {
                    return op.Failed("There is already keyword with this name");
                }
                db.Keywords.Add(Current);
                db.SaveChanges();
                return op.Succeeded(Current.KeywordID, "Keyword added successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to add " + ex.Message);
            }
        }

     
        public OperationResult Delete(Keyword keyword)
        {
            OperationResult op = new OperationResult(keyword.KeywordID, OperationState.CurrentState.Delete);
            try
            {
                //var key = db.Keywords.FirstOrDefault(x => x.KeywordID == ID);
                //if (key == null)
                //{
                //    return op.Failed("There isn't any keyword with this ID");
                //}
                db.Keywords.Remove(keyword);
                db.SaveChanges();
                return op.Succeeded("Keyword removed from database successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to remove "+ex.Message);
            }
        }
        public OperationResult Update(Keyword Current)
        {
            OperationResult op = new OperationResult(Current.KeywordID, OperationState.CurrentState.Update);
            try
            {
                if (ExistKeywordIDForOtherKeywordName(Current.KeywordID, Current.KeywordName))
                {
                    return op.Failed("There is already a keyword with this ID");
                }
                db.Keywords.Attach(Current);
                db.Entry<Keyword>(Current).State = EntityState.Modified;
                db.SaveChanges();
                return op.Succeeded("Keyword updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to update " + ex.Message);
            }
        }

    
        public Keyword Get(int ID)
        {
            return db.Keywords.FirstOrDefault(x => x.KeywordID == ID);
        }

        public List<Keyword> GetAll()
        {
            return db.Keywords.ToList();
        }
        public List<DrpKeywordModel> GetDrp(string KeywordName)
        {
            var q = from key in db.Keywords select key;

            if (!string.IsNullOrEmpty(KeywordName))
            {
                q = q.Where(x => x.KeywordName.StartsWith(KeywordName));
            }
            return q.Select(x => new DrpKeywordModel
            {
                KeywordID = x.KeywordID,
                KeywordName = x.KeywordName
            }).OrderByDescending(x => x.KeywordName).ToList();


        }
        public List<KeywordListItemForCategoryModel> GetKeywordsForCategory(int categoryid)
        {
            var keywords = from key in db.Keywords where key.Categories.Any(x => x.CategoryID == categoryid) select new KeywordListItemForCategoryModel { KeywordID=key.KeywordID,KeywordName=key.KeywordName,CategoryID= categoryid };
            var q = keywords.Count();
            return keywords.ToList();
        }
        public List<KeywordListItemForArticleModel> GetKeywordsForArticle(int ArticleID)
        {
            var keywords = from key in db.Keywords where key.Articles.Any(x => x.ArticleID == ArticleID) select new KeywordListItemForArticleModel { KeywordID = key.KeywordID, KeywordName = key.KeywordName, ArticleID = ArticleID };
            var q = keywords.Count();
            return keywords.ToList();
        }
        public bool ExistKeyword(string KeywordName)
        {
            return db.Keywords.Any(x => x.KeywordName == KeywordName);

        }
       
        public bool ExistKeywordIDForOtherKeywordName(int KeywordID,string KeywordName)
        {
            return db.Keywords.Any(x => x.KeywordID != KeywordID && x.KeywordName == KeywordName);
        }

        public List<KeywordListItemModel> Search(DomainModel.Query.Keyword.KeywordSearchModel sm, out int RecordCount)
        {
            var keywords = from keyword in db.Keywords select keyword;
            var t = keywords.Count();
            return KeywordSearchListItemModelUtility.ToSearch(keywords, sm,out RecordCount);
        }
    }
}
