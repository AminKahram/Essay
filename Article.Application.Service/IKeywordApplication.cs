using Article.Application.Model.Models.AddEditModels.Keyword;
using Article.DomainModel.Query.Keyword;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Service
{
    public interface IKeywordApplication
    {
        OperationResult Add(KeywordAddEditModel Current);

        OperationResult Delete(int ID);

        OperationResult Update(KeywordAddEditModel Current);
        KeywordAddEditModel UpdateGet(int ID);

        List<KeywordListItemModel> Search(KeywordSearchModel sm, out int RecordCount);


        DomainModel.Models.Keyword Get(int ID);
        List<DrpKeywordModel> GetDrp(string KeywordName);

        List<KeywordListItemForCategoryModel> GetKeywordsForCategory(int categoryid);
        List<KeywordListItemForArticleModel> GetKeywordsForArticle(int ArticleID);
        List<KeywordListItemModel> GetAll();


        bool ExistKeyword(string KeywordName);

        bool ExistKeywordIDForOtherKeywordName(int KeywordID, string KeywordName);
    }
}
