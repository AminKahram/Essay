using Article.Application.Model.Models.AddEditModels.Article;
using Article.Application.Implementation.ApplicationUtilities.Article;
using Article.Application.Service;
using Article.DomainModel.Query.Article;
using Article.Services.Services;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.DomainModel;

namespace Article.Application.Implementation
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository articleRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IAuthorRepository authorRepository;
        private readonly IKeywordApplication keywordApplication;
        public ArticleApplication(IArticleRepository articleRepository, ICategoryRepository categoryRepository, IAuthorRepository authorRepository, IKeywordApplication keywordApplication)
        {
            this.categoryRepository = categoryRepository;
            this.articleRepository = articleRepository;
            this.authorRepository = authorRepository;
            this.keywordApplication = keywordApplication;
        }
     
    
        public OperationResult Add(ArticleAddEditModel Current, string AuthorID,string KeywordID)
        {
            OperationResult op = new OperationResult(Current.ArticleID,OperationState.CurrentState.Add);
            try
            {
                int catid = Current.CategoryID;
                if (ExistArticle(Current.ArticleSubject))
                {
                    return op.Failed("There is already an article with this subject name");
                }
                if (categoryRepository.IsRoot(catid))
                {
                    return op.Failed("you cant add article in first layer of category");
                }
                if (categoryRepository.HasChildren(catid))
                {
                    return op.Failed("You can't add article  in second layer of category");
                }

                
                 op = articleRepository.Add(DBModelUtility.ToDBModel(Current),AuthorID.ToSplitInt(),KeywordID.ToSplitInt());
                return op.Succeeded("Article added successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Article failed to add "+ex.Message);
            }
           
          
        }
        //public OperationResult AssignKeywordArticleToArticle(DomainModel.Models.Article article, string KeywordID)
        //{
        //    throw new NotImplementedException();
        //}

       
        //public OperationResult AssignKeywordArticleToArticle(int ArticleID, int KeywordID)
        //{
        //    return articleRepository.AssignKeywordArticleToArticle(ArticleID, KeywordID);
        //}



        //public OperationResult DeleteKeywordArticleFromArticle(int ArticleID, int KeywordID)
        //{
        //    return articleRepository.DeleteKeywordArticleFromArticle(ArticleID, KeywordID);
        //}

        public bool ExistAArticleIDForOtherArticleName(int ArticleID, string ArticleName)
        {
            return articleRepository.ExistAArticleIDForOtherArticleName(ArticleID, ArticleName);
        }

        public bool ExistArticle(string ArticleName)
        {
            return articleRepository.ExistArticle(ArticleName);
        }

        public ArticleAddEditModel UpdateGet(int ID)
        {
            return AddEditModelUtility.ToAddEditModel(articleRepository.UpdateGet(ID));
        }

        public List<DomainModel.Models.Article> GetAll()
        {
            return articleRepository.GetAll();
        }

        public List<ArticleListItemModel> Search(ArticleSearchModel sm, out int RecordCount)
        {
            if (sm == null)
            {
                sm = new ArticleSearchModel { PageIndex = 0, PageSize = 10 };
            }
            if (sm.PageSize == 0)
            {
                sm.PageSize = 10;
            }
            return articleRepository.Search(sm, out RecordCount);

        }

        public OperationResult Update(ArticleAddEditModel Current, string AuthorID, string KeywordID)
        {
            OperationResult op = new OperationResult(Current.ArticleID,OperationState.CurrentState.Update);
            try
            {
                if (ExistAArticleIDForOtherArticleName(Current.ArticleID, Current.ArticleSubject))
                {
                    return op.Failed("There is already an article ID for this article name");
                }
                if (Current.CategoryID == 0)
                {
                    return op.Failed("Category can't be null");
                }
                if (categoryRepository.IsRoot(Current.CategoryID))
                {
                    return op.Failed("you cant add article in first layer of category");
                }
                if (categoryRepository.HasChildren(Current.CategoryID))
                {
                    return op.Failed("You can't add article  in second layer of category");
                }
                //var AuthorIDs = AuthorID.Split(",");
                //List<int> ToIntListAuthorID = new List<int>();
                //foreach (var item in AuthorIDs)
                //{
                //    if (item != "")
                //    {
                //        var autId = Convert.ToInt32(item);
                //        ToIntListAuthorID.Add(autId);
                //    }

                //}


                return articleRepository.Update(DBModelUtility.ToDBModel(Current), AuthorID.ToSplitInt(), KeywordID.ToSplitInt());
            }
            catch (Exception ex)
            {

                return op.Failed("Article failed to update "+ex.Message);
            }
           
        }
        //public OperationResult UpdateKeywordArticleFromArticle(DomainModel.Models.Article article, string KeywordID)
        //{
        //    throw new NotImplementedException();
        //}
        //public OperationResult UpdateKeywordArticleFromArticle(int ArticleID, int KeywordID)
        //{
        //    return articleRepository.UpdateKeywordArticleFromArticle(ArticleID, KeywordID);
        //}

        //public OperationResult AssignAuthorArticleToArticle(int ArticleID, int AuthorID)
        //{
        //    return articleRepository.AssignAuthorArticleToArticle(ArticleID, AuthorID);
        //}

        //public OperationResult DeleteAuthorArticleFromArticle(int ArticleID, int AuthorID)
        //{
        //    return articleRepository.DeleteAuthorArticleFromArticle(ArticleID, AuthorID);
        //}

        //public OperationResult UpdateAuthorArticleFromArticle(int ArticleID, int AuthorID)
        //{
        //    return articleRepository.UpdateAuthorArticleFromArticle(ArticleID, AuthorID);
        //}

        //public OperationResult AssignAuthorArticleToArticle(ArticleAddEditModel current, string AuthorID)
        //{
        //    OperationResult op = new OperationResult(OperationState.CurrentState.Add);
        //    if (current == null)
        //    {
        //        return op.Failed("there isn't any article to add authors to it");
        //    }
        //    var AuthorIDs = AuthorID.Split(",");
        //    List<int> ToIntListAuthorID = new List<int>();
        //    foreach (var item in AuthorIDs)
        //    {
        //        var autId = Convert.ToInt32(item);
        //        ToIntListAuthorID.Add(autId);
        //    }
        //    return articleRepository.AssignAuthorArticleToArticle(ToDBModel(current), ToIntListAuthorID);
        //}
        public OperationResult Delete(int ID)
        {
            OperationResult op = new OperationResult(ID, OperationState.CurrentState.Add);
            try
            {
                var qarticle = Get(ID);
                if (qarticle == null)
                {
                    return op.Failed("There isn't any Article with this ID");
                }
                return articleRepository.Delete(qarticle);
            }
            catch (Exception ex)
            {
                return op.Failed("Article failed to remove "+ex.Message);

            }


        }
        public OperationResult DeleteAuthorArticleFromArticle(int ArticleID, int AuthorID)
        {
            OperationResult op = new OperationResult(ArticleID,OperationState.CurrentState.Delete);
            try
            {
                var art = Get(ArticleID);
                if (art == null)
                {
                    return op.Failed("There isn't any article with this ID");
                }
                var aut = authorRepository.Get(AuthorID);
                if (aut == null)
                {
                    return op.Failed("There isn't any author with this ID");
                }
                var artaut = art.Authors.FirstOrDefault(x => x.AuthorID == AuthorID);
                if (artaut == null)
                {
                    return op.Failed("This author doesn't have this article");
                }
                op= articleRepository.DeleteAuthorArticleFromArticle(art, aut);
                return op.Succeeded("Author removed from article successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Author failed to remove from article "+ex.Message);
            }
            
        }
        public OperationResult DeleteKeywordArticleFromArticle(int ArticleID, int KeywordID)
        {
            OperationResult op = new OperationResult(ArticleID, OperationState.CurrentState.Delete);
            try
            {
                var art = Get(ArticleID);
                if (art == null)
                {
                    return op.Failed("There isn't any article with this ID");
                }
                
                var keyword = keywordApplication.Get(KeywordID);
                if (keyword == null)
                {
                    return op.Failed("There isn't any keyword with this ID");
                }
                var artkey = art.Keywords.FirstOrDefault(x => x.KeywordID == KeywordID);
                if (artkey == null)
                {
                    return op.Failed("This keyword doesn't have this article");
                }
                op = articleRepository.DeleteKeywordArticleFromArticle(art, keyword);
                return op.Succeeded("Keyword removed from article successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to remove from article "+ex.Message);
            }

        }
        public DomainModel.Models.Article Get(int ID)
        {
            return articleRepository.Get(ID);
        }
        public List<ArticleListItemForAuthorModel> GetAuthorsListForArticle(int AuthorID)
        {
            return articleRepository.GetAuthorsListForArticle(AuthorID);
        }

        public List<ArticleListItemForClientModel> GetClientArticles(ArticleSearchModel sm, out int RecordCount)
        {
            if (sm == null)
            {
                sm = new ArticleSearchModel { PageIndex = 0, PageSize = 10 };
            }
            if (sm.PageSize == 0)
            {
                sm.PageSize = 10;
            }
            return articleRepository.GetClientArticles(sm, out RecordCount);
        }

        public ArticleClientItemModel GetClientArticle(int ID)
        {
            return articleRepository.GetClientArticle(ID);
        }
    }
}
