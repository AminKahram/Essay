using Article.DomainModel.Query.Category;
using Article.DomainModel.Query.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Category
{
    public class CategoryUpdateItemModelUtility
    {
        public static CategoryUpdateItemModel ToCategoryUpdateItemModel(DomainModel.Models.Category category, IQueryable<DrpKeywordModel> keywords)
        {
            //if (category.Parent == null)
            //{

            //}
            var toupdatemodel = new CategoryUpdateItemModel
            {
                CategoryID = category.CategoryID,
                CategoryName=category.CategoryName,
                Slug=category.Slug,
                ParentID=category.ParentID
            };
            var KeywordID = "";
            var KeywordName = "";
            foreach (var items in keywords)
            {
                KeywordName = KeywordName + items.KeywordName + ",";
                KeywordID = KeywordID + items.KeywordID + ",";
            }
            toupdatemodel.KeywordID = KeywordID;
            toupdatemodel.KeywordName = KeywordName;
            //var AuthorName = "";
            //var KeywordName = "";
            ////foreach (var items in authors)
            ////{
            ////    AuthorName = AuthorName + items + ",";
            ////}
            //foreach (var items in keywords)
            //{
            //    KeywordName = KeywordName + items + ",";
            //}
            ////toupdatemodel.AuthorID = AuthorName;
            //toupdatemodel.KeywordID = KeywordName;
            return toupdatemodel;
        }
    }
}
