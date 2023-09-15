using Article.DomainModel.Models;
using Article.DomainModel.Query.Article;
using Article.DomainModel.Query.Author;
using Article.DomainModel.Query.Keyword;
using Article.Persistence.EF.RepositoryUtilities.Article;
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
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArticleContext db;
        //private readonly ICategoryRepository categoryRepository;
        public ArticleRepository(ArticleContext db)
        {
            this.db = db;
        }
        public OperationResult Add(DomainModel.Models.Article Current, List<int> authorID, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                
                db.Articles.Add(Current);
                db.SaveChanges();
                AssignAuthorArticleToArticle(Current, authorID);
                AssignKeywordArticleToArticle(Current, KeywordID);
                return op.Succeeded(Current.ArticleID, "Article addede successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Article failed to add " + ex.Message);
            }
        }

      
      

        public OperationResult AssignAuthorArticleToArticle(DomainModel.Models.Article article, List<int> authorID)
        {
            OperationResult op = new OperationResult(article.ArticleID,OperationState.CurrentState.Add);
            try
            {
                
                foreach (var item in authorID)
                {
                    var qauthor = db.Authors.FirstOrDefault(x => x.AuthorID == item);
                    if (qauthor == null)
                    {
                        return op.Failed("There isn't any author with this ID");
                    }
                    else
                    {

                        article.Authors.Add(qauthor);
                        db.SaveChanges();
                    }
                }
                return op.Succeeded("Authors added to article successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Authors failed to add article " + ex.Message);
            }
        }

        public OperationResult AssignKeywordArticleToArticle(DomainModel.Models.Article article, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(article.ArticleID, OperationState.CurrentState.Add);
            try
            {
               
                foreach (var item in KeywordID)
                {
                    var qkeyword = db.Keywords.FirstOrDefault(x => x.KeywordID == item);
                    if (qkeyword == null)
                    {
                        return op.Failed("There isn't any keyword with this ID");
                    }
                    else
                    {

                        article.Keywords.Add(qkeyword);
                        db.SaveChanges();
                    }
                }
                return op.Succeeded("Keywords added to article successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Keywords failed to add to article " + ex.Message);
            }
        }
        public OperationResult Delete(DomainModel.Models.Article article)
        {
            OperationResult op = new OperationResult(article.ArticleID,OperationState.CurrentState.Delete);
            try
            {
                db.Articles.Remove(article);
                db.SaveChanges();
                return op.Succeeded("Article removed successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Article failed to remove " + ex.Message);
            }

        }

     
        public OperationResult DeleteAuthorArticleFromArticle(DomainModel.Models.Article article,Author author )
        {
            OperationResult op = new OperationResult(article.ArticleID,OperationState.CurrentState.Delete);
            try
            {
               
                article.Authors.Remove(author);
                db.SaveChanges();
                return op.Succeeded("Author removed from article successfully ");

            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to remove from article"+ex.Message);
            }
        }
       
        public OperationResult DeleteKeywordArticleFromArticle(DomainModel.Models.Article article, Keyword keyword)
        {
            OperationResult op = new OperationResult(article.ArticleID, OperationState.CurrentState.Delete);
            try
            {

                article.Keywords.Remove(keyword);
                db.SaveChanges();
                return op.Succeeded("Keyword removed from article successfully ");

            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to remove from article" + ex.Message);
            }
        }

        public bool ExistAArticleIDForOtherArticleName(int ArticleID, string ArticleName)
        {
            return db.Articles.Any(x => x.ArticleID != ArticleID && x.ArticleSubject == ArticleName);
        }

        public bool ExistArticle(string ArticleName)
        {
            return db.Articles.Any(x => x.ArticleSubject == ArticleName);
        }

        public ArticleUpdateItemModel UpdateGet(int ID)
        {
            var articles = GetUpdateDB(ID);
            var parentID = db.Categories.FirstOrDefault(x => x.CategoryID == articles.CategoryID).ParentID;


            //var authors = from aut in db.Authors where aut.Articles.Any(x=>x.ArticleID==ID) select aut.AuthorName;
            var authors = from aut in db.Authors where aut.Articles.Any(x=>x.ArticleID==ID) select new DrpAuthorModel { AuthorID = aut.AuthorID, AuthorName = aut.AuthorName };
            var keywords = from key in db.Keywords where key.Articles.Any(x=>x.ArticleID==ID) select new DrpKeywordModel {KeywordID=key.KeywordID,KeywordName=key.KeywordName };
            var toarticelupdate = ArticleUpdateItemModelUtility.ToArticleUpdateItemModel(articles,authors,keywords,parentID.Value);

            return toarticelupdate;
        }

        public List<DomainModel.Models.Article> GetAll()
        {
            return db.Articles.Include(x=>x.Keywords).ToList();
        }

        public List<ArticleListItemModel> Search(ArticleSearchModel sm, out int RecordCount)
        {
            //RECODE
            IQueryable<Article.DomainModel.Models.Article> articles;
            if (sm.KeywordSelected != null && sm.KeywordSelected != 0)
            {
                articles = from art in db.Articles where art.Keywords.Any(x => x.KeywordID == sm.KeywordSelected) select art;
            }
            else
            {
                articles = from art in db.Articles select art;
            }
            //if (sm.KeywordSelected != null && sm.KeywordSelected != 0)
            //{
            //    articles = articles.Where(x => x.Keywords.Any(y => y.KeywordID == sm.KeywordSelected));
            //}
            var authors = from aut in db.Authors select aut ;
            var keywords = from key in db.Keywords select key;
            return ArticleSearchListItemModelUtility.ToListItemModel(articles, authors, keywords, sm,out  RecordCount);
        }
        public OperationResult Update(DomainModel.Models.Article Current, List<int> authorID, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(Current.ArticleID, OperationState.CurrentState.Update);
            try
            {
                var art =Get(Current.ArticleID) ;
                art.ArticleFile = Current.ArticleFile;
                art.ArticleImage = Current.ArticleImage;
                art.ArticleImageName = Current.ArticleImageName;
                art.ArticleFileName = Current.ArticleFileName;
                art.ArticleSubject = Current.ArticleSubject;
                art.CategoryID = Current.CategoryID;
                art.Description = Current.Description;
                art.PublicationDate = Current.PublicationDate;
                art.Size = Current.Size;
                art.SmallDescription = Current.SmallDescription;

                art.Authors.Clear();
                art.Keywords.Clear();
                             
                UpdateAuthorArticleFromArticle(art, authorID);
                UpdateKeywordArticleFromArticle(art, KeywordID);

                db.Articles.Attach(art);

                db.Entry<Article.DomainModel.Models.Article>(art).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                //var author = from aut in db.Articles where aut.Authors.Any(x => x.ArticleID == Current.ArticleID) select aut.AuthorID;

                return op.Succeeded("Article updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Article failed to update " + ex.Message);
            }
        }
        public OperationResult UpdateAuthorArticleFromArticle(DomainModel.Models.Article  article,List<int> authorID)
        {
            OperationResult op = new OperationResult(article.ArticleID, OperationState.CurrentState.Update);
            try
            {
                foreach (var item in authorID)
                {
                    var qauthor = db.Authors.FirstOrDefault(x => x.AuthorID == item);
                    article.Authors.Add(qauthor);
                    db.SaveChanges();
                }
                return op.Succeeded("Author attached to article successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to attached to article "+ex.Message);
            }
        }
        public OperationResult UpdateKeywordArticleFromArticle(DomainModel.Models.Article article, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(article.ArticleID, OperationState.CurrentState.Update);
            try
            {
                foreach (var item in KeywordID)
                {
                    var qkeyword = db.Keywords.FirstOrDefault(x => x.KeywordID == item);
                    article.Keywords.Add(qkeyword);
                    db.SaveChanges();

                }


                return op.Succeeded("Keyword attached to article successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to attached to article " + ex.Message);
            }
        }
        public DomainModel.Models.Article Get(int ID)
        {
            return db.Articles.Include(x=>x.Authors).Include(x=>x.Keywords).FirstOrDefault(x => x.ArticleID == ID);
            //var authors = from aut in db.Authors where aut.Articles.Any(x => x.ArticleID == ID) select aut;
            //var keywords = from key in db.Keywords where key.Articles.Any(x => x.ArticleID == ID) select key;
            //return db.Articles.Select(x => new DomainModel.Models.Article
            //{
            //    ArticleID = x.ArticleID,
            //    ArticleFile = x.ArticleFile,
            //    ArticleImage = x.ArticleImage,
            //    ArticleImageName = x.ArticleImageName,
            //    ArticleSubject = x.ArticleSubject,
            //    CategoryID = x.CategoryID,
            //    Category = x.Category,
            //    Description = x.Description,
            //    PublicationDate = x.PublicationDate,
            //    Size = x.Size,
            //    SmallDescription = x.SmallDescription,
            //    Authors=x.Authors.ToList(),
            //    Keywords=x.Keywords.ToList()
            //}).FirstOrDefault(x => x.ArticleID == ID);
        }
        public List<ArticleListItemForAuthorModel> GetAuthorsListForArticle(int AuthorID)
        {
            //var Articles = from art in db.Articles where art.Authors.Any(x => x.AuthorID == AuthorID) select new ArticleListItemForAuthorModel 
            //{ 
            //    ArticleID = art.ArticleID, 
            //    ArticleSubject = art.ArticleSubject, 
            //    ArticlImageName = art.ArticleImageName,
            //    AuthorName = art.Authors. 
            //}
            //return Articles.ToList();
           var articles = from art in db.Articles where art.Authors.Any(x => x.AuthorID == AuthorID) select art;
            var authors = from aut in db.Authors select aut;
            var keywords = from key in db.Keywords select key;
            return ArticleSearchListItemForAuthorModelUtility.ToListItem(articles, authors, keywords, AuthorID);
        }
        public DomainModel.Models.Article GetUpdateDB(int ID)
        {
            return db.Articles.FirstOrDefault(x => x.ArticleID == ID);

        }
        public List<ArticleListItemForClientModel> GetClientArticles(ArticleSearchModel sm, out int RecordCount)
        {
            var articles = from art in db.Articles where art.CategoryID ==sm.CategoryID select art;
            var authors = from aut in db.Authors select aut;
            return ArticleSearchListForClientUtility.ToClientList(articles, authors,sm, out RecordCount);
        }
        public ArticleClientItemModel GetClientArticle(int ID)
        {
            var article = db.Articles.FirstOrDefault(x=>x.ArticleID==ID);
            var authors = from aut in db.Authors select aut;
            return ArticleSearchListForClientUtility.ToClientItem(article, authors);
        }
    }
}
