using Article.DomainModel.Models;
using Article.DomainModel.Query.Keyword;
using Framework.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Services.Services
{
    public interface IKeywordRepository:IBaseRepositorySearchable<Keyword,int, KeywordSearchModel, KeywordListItemModel>
    {
        bool ExistKeyword(string AuthorName);
        bool ExistKeywordIDForOtherKeywordName(int KeywordID, string KeywordName);
        List<DrpKeywordModel> GetDrp(string KeywordName);
        List<KeywordListItemForCategoryModel> GetKeywordsForCategory(int categoryid);
        List<KeywordListItemForArticleModel> GetKeywordsForArticle(int ArticleID);

    }
}
