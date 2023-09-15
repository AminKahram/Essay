using Article.Application.Model.Models.AddEditModels.Category;
using Article.DomainModel.Models;
using Article.DomainModel.Query.Category;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Service
{
    public interface ICategoryApplication
    {
        OperationResult Add(CategoryAddEditModel Current);
        OperationResult Delete(int ID);
        OperationResult Update(CategoryAddEditModel Current);
        CategoryAddEditModel UpdateGet(int ID);
        Category Get(int ID);
        List<Category> GetAll();
        List<CategoryListItemModel> Search(CategorySearchModel sm, out int RecordCount);


        //OperationResult AssignKeywordCategoryToCategory(Category category, string KeywordID);
        //OperationResult DeleteKeywordArticleFromArticle(Category category, Keyword keyword);
        OperationResult DeleteKeywordCategoryFromCategory(int CategoryID, int KeywordID);

        //OperationResult UpdateKeywordCategoryFromCategory(int CategoryID, int KeywordID);

        List<DrpCategoryListItemModel> GetChildren(int CategoryID);
        DrpCategoryListItemModel GetParent(int CategoryID);
        CategoryUpdateDrpListItem GetUpdateCategoryDrp(int CategoryID);

        List<DrpCategoryListItemModel> GetRoots();

        bool HasChildren(int CategoryID);
        bool HasArticle(int CategoryID);
        bool IsChildren(int? CategoryID);
        bool IsRoot(int CategoryID);
        bool ExistCategory(string CategoryName);
        bool ExistCategoryIDForOtherCategoryName(int CategoryID, string CategoryName);




       
    }
}
