using Article.DomainModel.Models;
using Article.DomainModel.Query.Category;
using Article.DomainModel.Query.Keyword;
using Article.Persistence.EF.RepositoryUtilities.Category;
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
    public class CategoryRepository  : ICategoryRepository
    {
        private readonly ArticleContext db;
        public CategoryRepository(ArticleContext db)
        {
            this.db = db;
        }
        public OperationResult Add(Category Current, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                db.Categories.Add(Current);
                db.SaveChanges();
                AssignKeywordCategoryToCategory(Current, KeywordID);
                return op.Succeeded(Current.CategoryID, "Category Added successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Category failed to add " + ex.Message);
            }
        }
        public OperationResult AssignKeywordCategoryToCategory(Category category, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(category.CategoryID, OperationState.CurrentState.Add);
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
                        category.Keywords.Add(qkeyword);
                        db.SaveChanges();
                    }
                }
                return op.Succeeded("Keywords added to categoty successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Keywords failed to add to categoty " + ex.Message);
            }
        }
        public OperationResult Delete(Category category)
        {
            OperationResult op = new OperationResult(category.CategoryID, OperationState.CurrentState.Delete);
            try
            {
                db.Categories.Remove(category);
                db.SaveChanges();
                return op.Succeeded("Category removed successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Category failed to remove " + ex.Message);
            }
        }

  
        public OperationResult DeleteKeywordCategoryFromCategory(Category category, Keyword keyword)
        {
            OperationResult op = new OperationResult(category.CategoryID, OperationState.CurrentState.Delete);
            try
            {

                category.Keywords.Remove(keyword);
                db.SaveChanges();
                return op.Succeeded("Keyword removed from category successfully ");

            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to remove from category" + ex.Message);
            }
        }
        //public OperationResult DeleteKeywordCategoryFromCategory(int CategoryID, int KeywordID)
        //{
        //    OperationResult op = new OperationResult(OperationState.CurrentState.Delete);
        //    try
        //    {
        //        var key = db.Keywords.FirstOrDefault(x => x.KeywordID == KeywordID);
        //        if (key == null)
        //        {
        //            return op.Failed("There isn't any keyword with this ID");
        //        }
        //        var cat = db.Categories.FirstOrDefault(x => x.CategoryID == CategoryID);
        //        if (cat == null)
        //        {
        //            return op.Failed("There isn't any category with this ID");
        //        }
        //        var catkey = db.keywordCategories.FirstOrDefault(x => x.CategoryID == CategoryID && x.KeywordID == KeywordID);
        //        if (catkey == null)
        //        {
        //            return op.Failed("There isn't any category relted to this keyword");
        //        }
        //        cat.KeywordCategories.Remove(catkey);
        //        db.SaveChanges();
        //        return op.Succeeded(catkey.KeywordCategoryID, "Keyword removed from category successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return op.Failed("Keywrd failed to remove from category " + ex.Message);
        //    }
        //}

        public bool ExistCategory(string CategoryName)
        {
            return db.Categories.Any(x => x.CategoryName == CategoryName);
        }

        public bool ExistCategoryIDForOtherCategoryName(int CategoryID, string CategoryName)
        {
            return db.Categories.Any(x => x.CategoryID != CategoryID && x.CategoryName == CategoryName);
        }

        public Category Get(int ID)
        {
            return db.Categories.Include(x=>x.Parent).Include(x=>x.Keywords).FirstOrDefault(x => x.CategoryID == ID);
        }

        //public List<CategoryMenuItemModel> GetAll()
        public List<Category> GetAll()
        {
            return db.Categories.ToList();
            //return db.Categories.Select(x=>new CategoryMenuItemModel { 
            //    CategoryID=x.CategoryID,CategoryName=x.CategoryName,x
            //}).ToList();
        }
        //public List<CategoryMenuItemModel> GetAll()
        //{
        //    return db.Categories.Select(x => new CategoryMenuItemModel
        //    {
        //        CategoryID = x.CategoryID,
        //        CategoryName = x.CategoryName,
        //        x
        //    }).ToList();
        //}
        public List<DrpCategoryListItemModel> GetChildren(int CategoryID)
        {
            return db.Categories.Select(x => new DrpCategoryListItemModel
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                HasChildren = x.Children.Any(),
                IsRoot = x.ParentID == null,
                ParentID = x.ParentID
            }).Where(x=>x.ParentID==CategoryID).ToList();

        }

        public DrpCategoryListItemModel GetParent(int CategoryID)
        {
            var parentID = db.Categories.FirstOrDefault(x => x.CategoryID == CategoryID).ParentID;
            return db.Categories.Select(x => new DrpCategoryListItemModel
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                Slug=x.Slug,
                HasChildren = x.Children.Any(),
                IsRoot = x.ParentID == null,
                ParentID = x.ParentID
            }).FirstOrDefault(x=>x.CategoryID==parentID);
        }

        public List<DrpCategoryListItemModel> GetRoots()
        {
            return db.Categories.Select(x => new DrpCategoryListItemModel
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                HasChildren = x.Children.Any(),
                IsRoot = x.ParentID == null,
                ParentID = x.ParentID
            }).Where(x => x.ParentID == null).ToList();
        }

        public bool HasArticle(int CategoryID)
        {
            return db.Articles.Any(x => x.CategoryID == CategoryID);
        }

        public bool HasChildren(int CategoryID)
        {
            return db.Categories.Any(x => x.ParentID == CategoryID);
        }

        public bool IsChildren(int? CategoryID)
        {
          
            var parentID = db.Categories.FirstOrDefault(x => x.CategoryID == CategoryID).ParentID;
            if (parentID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsRoot(int CategoryID)
        {
            var cat= db.Categories.FirstOrDefault(x=>x.CategoryID==CategoryID);
            if (cat.ParentID == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public List<CategoryListItemModel> Search(CategorySearchModel sm, out int RecordCount)
        //{
        //    throw new NotImplementedException();
        //}

        public List<CategoryListItemModel> Search(CategorySearchModel sm, out int RecordCount)
        {
            var q = from cat in db.Categories select cat;
            if (!string.IsNullOrEmpty(sm.CategoryName))
            {
                q = q.Where(x => x.CategoryName.StartsWith(sm.CategoryName));
            }
            //if (sm.KeywordID != null)
            //{
            //    q = q.Where(x => x.KeywordCategories.Any(y => y.KeywordID == sm.KeywordID));
            //}
            RecordCount = q.Count();
            q = q.OrderByDescending(x => x.CategoryID).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize);
            var q2 = q.Select(x => new CategoryListItemModel
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                ParentName = x.Parent.CategoryName,
                Articles = x.Articles.Count(),
            });
            return q2.ToList();
        }

        public OperationResult Update(Category Current, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(Current.CategoryID, OperationState.CurrentState.Update);
            try
            {
                //if (!ExistCategory(Current.CategoryName))
                //{
                //    return op.Failed("There isn't any category with this category name");
                //}
                //if (ExistCategoryIDForOtherCategoryName(Current.CategoryID, Current.CategoryName))
                //{
                //    return op.Failed("There is already a category Id for this category name");
                //}
                var cat = Get(Current.CategoryID);
                cat.CategoryName = Current.CategoryName;
                cat.Slug = Current.Slug;
                cat.ParentID = Current.ParentID;
                cat.Keywords.Clear();
                UpdateKeywordCategoryFromCategory(cat, KeywordID);
                db.Categories.Attach(cat);
                db.Entry<Category>(cat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return op.Succeeded("Category updated successfully"); 
            }
            catch (Exception ex)
            {
                return op.Failed("category failed to update " + ex.Message);
            }
        }

        public OperationResult UpdateKeywordCategoryFromCategory(Category category, List<int> KeywordID)
        {
            OperationResult op = new OperationResult(category.CategoryID, OperationState.CurrentState.Update);
            try
            {
                foreach (var item in KeywordID)
                {
                    var qkeyword = db.Keywords.FirstOrDefault(x => x.KeywordID == item);
                    category.Keywords.Add(qkeyword);
                    db.SaveChanges();

                }


                return op.Succeeded("Keyword attached to category successfully");

            }
            catch (Exception ex)
            {
                return op.Failed("Keyword failed to attached to category " + ex.Message);
            }
        }
        public CategoryUpdateItemModel UpdateGet(int ID)
        {
            var category = GetUpdateDB(ID);
            //var keywords = category.Keywords.Select(x => x.KeywordName);
            //var keywords = from key in db.Keywords where key.Articles.Any(x => x.ArticleID == ID) select key.KeywordName;
            var keywords = from key in db.Keywords where key.Categories.Any(x => x.CategoryID == ID) select new DrpKeywordModel { KeywordID = key.KeywordID, KeywordName = key.KeywordName };

            var toarticelupdate = CategoryUpdateItemModelUtility.ToCategoryUpdateItemModel(category, keywords);

            return toarticelupdate;
        }
        public Category GetUpdateDB(int ID)
        {
            return db.Categories.FirstOrDefault(x => x.CategoryID == ID);

        }
        public CategoryUpdateDrpListItem GetUpdateCategoryDrp(int CategoryID)
        {
            var catparent = GetParent(CategoryID);
            var cat = db.Categories.Select(x => new CategoryUpdateDrpListItem {CategoryID=x.CategoryID,CategoryName=x.CategoryName,ParentID=catparent.CategoryID,ParentName=catparent.CategoryName }).FirstOrDefault(x => x.ParentID == catparent.CategoryID);
            //DrpCategoryListItemModel drpCategory = new DrpCategoryListItemModel();
            return cat;
        }

        //public OperationResult UpdateKeywordCategoryFromCategory(int CategoryID, int KeywordID)
        //{
        //    OperationResult op = new OperationResult(OperationState.CurrentState.Update);
        //    try
        //    {
        //        var key = db.Keywords.FirstOrDefault(x => x.KeywordID == KeywordID);
        //        if (key == null)
        //        {
        //            return op.Failed("There isn't any keyword with this ID");
        //        }
        //        var cat = db.Categories.FirstOrDefault(x => x.CategoryID == CategoryID);
        //        if (cat == null)
        //        {
        //            return op.Failed("There isn't any category with this ID");
        //        }
        //        KeywordCategory keywordCategory = new KeywordCategory
        //        {
        //            CategoryID = CategoryID,
        //            KeywordID = KeywordID
        //        };
        //        db.keywordCategories.Attach(keywordCategory);
        //        db.Entry<KeywordCategory>(keywordCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //        db.SaveChanges();
        //        return op.Succeeded(keywordCategory.KeywordCategoryID, "Keyword and category successfully updated");

        //    }
        //    catch (Exception ex)
        //    {
        //        return op.Failed("Keyword and category failed to update " + ex.Message);
        //    }
        //}
    }
}
