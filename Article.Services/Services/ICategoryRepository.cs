using Article.DomainModel.Models;
using Article.DomainModel.Query.Category;
using Framework.Services.BaseServiceModel;
using Framework.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Services.Services
{
    public interface ICategoryRepository
    {
        OperationResult Add(Category Current,List<int> KeywordID);
        OperationResult Delete(Category category);
        OperationResult Update(Category Current, List<int> KeywordID);
        CategoryUpdateItemModel UpdateGet(int ID);
        Category Get(int ID);
        List<Category> GetAll();
        List<CategoryListItemModel> Search(CategorySearchModel sm, out int RecordCount);

        bool ExistCategory(string CategoryName);
        bool ExistCategoryIDForOtherCategoryName(int CategoryID, string CategoryName);
        //root buss
        bool HasChildren(int CategoryID);
        bool HasArticle(int CategoryID);
        bool IsChildren(int? CategoryID);
        bool IsRoot(int CategoryID);
        DrpCategoryListItemModel GetParent(int CategoryID);
        CategoryUpdateDrpListItem GetUpdateCategoryDrp(int CategoryID);
        List<DrpCategoryListItemModel> GetChildren(int CategoryID);
        List<DrpCategoryListItemModel> GetRoots();
        //keyword
        OperationResult AssignKeywordCategoryToCategory(Category category,List<int> KeywordID);
        OperationResult UpdateKeywordCategoryFromCategory(Category category, List<int> KeywordID);
        OperationResult DeleteKeywordCategoryFromCategory(Category category, Keyword keyword);
    }
}
