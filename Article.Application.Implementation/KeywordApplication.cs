using Article.Application.Implementation.ApplicationUtilities.Keyword;
using Article.Application.Model.Models.AddEditModels.Keyword;
using Article.Application.Service;
using Article.DomainModel.Models;
using Article.DomainModel.Query.Keyword;
using Article.Services.Services;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation
{
    public class KeywordApplication : IKeywordApplication
    {
        private readonly IKeywordRepository keywordRepository;
        public KeywordApplication(IKeywordRepository keywordRepository)
        {
            this.keywordRepository = keywordRepository;
        }
        public OperationResult Add(KeywordAddEditModel Current)
        {
           return keywordRepository.Add(KeywordDBModelUtility.ToDB(Current));
        }

        public OperationResult Delete(int ID)
        {
            return keywordRepository.Delete(Get(ID));
        }

        public bool ExistKeyword(string KeywordName)
        {
            return keywordRepository.ExistKeyword(KeywordName);
        }

        public bool ExistKeywordIDForOtherKeywordName(int KeywordID, string KeywordName)
        {
            return keywordRepository.ExistKeywordIDForOtherKeywordName(KeywordID, KeywordName);
        }

        public Keyword Get(int ID)
        {
            return keywordRepository.Get(ID);
        }

        public List<KeywordListItemModel> GetAll()
        {
            return KeywordListItemUtility.ToListItem(keywordRepository.GetAll());
        }

        public List<KeywordListItemModel> Search(KeywordSearchModel sm, out int RecordCount)
        {
            if (sm == null)
            {
                sm = new KeywordSearchModel { PageIndex = 0, PageSize = 10 };
            }
            if (sm.PageSize == 0)
            {
                sm.PageSize = 10;
            }
            return keywordRepository.Search(sm, out RecordCount);
        }
        public List<DrpKeywordModel> GetDrp(string KeywordName)
        {
            return keywordRepository.GetDrp(KeywordName);
        }

        public OperationResult Update(KeywordAddEditModel Current)
        {
            return keywordRepository.Update(KeywordDBModelUtility.ToDB(Current));
         
        }

        public List<KeywordListItemForCategoryModel> GetKeywordsForCategory(int categoryid)
        {
            return keywordRepository.GetKeywordsForCategory(categoryid);
        }

        public List<KeywordListItemForArticleModel> GetKeywordsForArticle(int ArticleID)
        {
            return keywordRepository.GetKeywordsForArticle(ArticleID);
        }


        public KeywordAddEditModel UpdateGet(int ID)
        {
            return KeywordAddEditModelUtility.ToAddEdit(Get(ID));
        }
    }
}
