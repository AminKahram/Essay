using Article.Application.Implementation.ApplicationUtilities.Category;
using Article.Application.Model.Models.AddEditModels.Category;
using Article.Application.Service;
using Article.DomainModel.Models;
using Article.DomainModel.Query.Category;
using Article.Services.Services;
using Framework.DomainModel;
using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IKeywordApplication keywordApplication;
        public CategoryApplication(ICategoryRepository categoryRepository, IKeywordApplication keywordApplication)
        {
            this.categoryRepository = categoryRepository;
            this.keywordApplication = keywordApplication;
        }
        //private Category ToDBModel(CategoryAddEditModel addEditModel)
        //{
        //    return new Category
        //    {
        //        CategoryName = addEditModel.CategoryName,
        //        ParentID = addEditModel.ParentID,
        //        Slug = addEditModel.Slug
        //    };
        //}
        //private CategoryAddEditModel ToAddEditmodel(Category dbmodelcat)
        //{
        //    return new CategoryAddEditModel
        //    {
        //        CategoryID = dbmodelcat.CategoryID,
        //        CategoryName = dbmodelcat.CategoryName,
        //        Slug = dbmodelcat.Slug,
        //        ParentID = dbmodelcat.ParentID
        //    };
        //}
        public OperationResult Add(CategoryAddEditModel Current)
        {
            OperationResult op = new OperationResult(Current.CategoryID,OperationState.CurrentState.Add);
            try
            {
                if (Current.ParentID != null && IsChildren(Current.ParentID))
                {
                    return op.Failed("you can't add layer 3 category");
                }
                if (Current.ParentID != null && ExistCategory(Current.CategoryName))
                {
                    return op.Failed("There is already a category with this name");
                }
               return categoryRepository.Add(DBModelUtility.ToDB(Current),Current.KeywordID.ToSplitInt());
               
            }
            catch (Exception ex)
            {
                return op.Failed("Category failed to add " + ex.Message);

            }


        }

        //public OperationResult AssignKeywordCategoryToCategory(Category category, string KeywordID)
        //{
        //    return categoryRepository.AssignKeywordCategoryToCategory(category, KeywordID.ToSplitInt());
        //}

        public OperationResult Delete(int ID)
        {
            OperationResult op = new OperationResult(ID, OperationState.CurrentState.Delete);
            try
            {
                var cat = Get(ID);
                if (cat == null)
                {
                    return op.Failed("There isn't any category with this ID");
                }
                if (HasChildren(ID))
                {
                    return op.Failed("This category has children");
                }
                if (HasArticle(ID))
                {
                    return op.Failed("this category has related articles");
                }
                return categoryRepository.Delete(Get(ID));

            }
            catch (Exception ex)
            {
                return op.Failed("Category failed to remove " + ex.Message);
            }
        }

        public OperationResult DeleteKeywordCategoryFromCategory(int CategoryID, int KeywordID)
        {
            OperationResult op = new OperationResult(CategoryID, OperationState.CurrentState.Delete);
            try
            {
                var cat = Get(CategoryID);
                if (cat == null)
                {
                    return op.Failed("There isn't any category with this ID");
                }

                var keyword = keywordApplication.Get(KeywordID);
                //var keyword = cat.Keywords.FirstOrDefault(x => x.KeywordID == KeywordID);
                if (keyword==null)
                {
                    return op.Failed("There isn't any keyword with this ID");
                }
                var catkey = cat.Keywords.FirstOrDefault(x => x.KeywordID == KeywordID);
                if (catkey == null)
                {
                    return op.Failed("This keyword doesn't have this category");
                }
                op = categoryRepository.DeleteKeywordCategoryFromCategory(cat, keyword);
                return op.Succeeded("Keyword removed from category successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to remove from category " + ex.Message);
            }
            //return categoryRepository.DeleteKeywordCategoryFromCategory(current, KeywordID);
        }

        public bool ExistCategory(string CategoryName)
        {
            return categoryRepository.ExistCategory(CategoryName);
        }

        public bool ExistCategoryIDForOtherCategoryName(int CategoryID, string CategoryName)
        {
            return categoryRepository.ExistCategoryIDForOtherCategoryName(CategoryID, CategoryName);
        }

        public Category Get(int ID)
        {
            return categoryRepository.Get(ID);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public List<DrpCategoryListItemModel> GetChildren(int CategoryID)
        {
            return categoryRepository.GetChildren(CategoryID);
        }

        public DrpCategoryListItemModel GetParent(int CategoryID)
        {
            return categoryRepository.GetParent(CategoryID);
        }

        public List<DrpCategoryListItemModel> GetRoots()
        {
            return categoryRepository.GetRoots();
        }

        public bool HasChildren(int CategoryID)
        {
            return categoryRepository.HasChildren(CategoryID);
        }

        public bool IsChildren(int? CategoryID)
        {
            return categoryRepository.IsChildren(CategoryID);
        }

        public List<CategoryListItemModel> Search(CategorySearchModel sm, out int RecordCount)
        {
            if (sm == null)
            {
                sm = new CategorySearchModel { PageIndex = 0, PageSize = 10 };
            }
            if (sm.PageSize == 0)
            {
                sm.PageSize = 10;
            }
            return categoryRepository.Search(sm, out RecordCount);
        }

        public OperationResult Update(CategoryAddEditModel Current)
        {
            OperationResult op = new OperationResult(Current.CategoryID,OperationState.CurrentState.Update);
            try
            {
                if (Current.ParentID != null && IsChildren(Current.ParentID))
                {
                    return op.Failed("you can't add layer 3 category");
                }
                if (IsRoot(Current.CategoryID) && Current.ParentID!=null && HasChildren(Current.CategoryID))
                {
                    return op.Failed("Category has children");
                }
                if(Current.ParentID==null && HasArticle(Current.CategoryID))
                {
                    return op.Failed("Category has related articles");
                }
                //if (ExistCategory(Current.CategoryName))
                //{
                //    return op.Failed("There is already a category with this category name");
                //}
                if (ExistCategoryIDForOtherCategoryName(Current.CategoryID, Current.CategoryName))
                {
                    return op.Failed("There is already a category Id for this category name");
                }
                return categoryRepository.Update(DBModelUtility.ToDB(Current),Current.KeywordID.ToSplitInt());
            }
            catch (Exception ex)
            {
                return op.Failed("Failed to update category " + ex.Message);
            }

        }

        //public OperationResult UpdateKeywordCategoryFromCategory(int CategoryID, int KeywordID)
        //{
        //    return categoryRepository.UpdateKeywordCategoryFromCategory(CategoryID, KeywordID);
        //}

        public bool IsRoot(int CategoryID)
        {
            return categoryRepository.IsRoot(CategoryID);
        }

        public bool HasArticle(int CategoryID)
        {
            return categoryRepository.HasArticle(CategoryID);
        }

        public CategoryAddEditModel UpdateGet(int ID)
        {
            return AddEditModelUtility.ToAddEdit(categoryRepository.UpdateGet(ID));
        }

        public CategoryUpdateDrpListItem GetUpdateCategoryDrp(int CategoryID)
        {
            return categoryRepository.GetUpdateCategoryDrp(CategoryID);
        }
    }
}
