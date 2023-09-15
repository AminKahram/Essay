using Article.Application.Model.Models.AddEditModels.Category;
using Article.DomainModel.Query.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Category
{
    public class AddEditModelUtility
    {
        public static CategoryAddEditModel ToAddEdit(CategoryUpdateItemModel categoryUpdate)
        {
            return new CategoryAddEditModel
            {
                CategoryID = categoryUpdate.CategoryID,
                CategoryName = categoryUpdate.CategoryName,
                Slug = categoryUpdate.Slug,
                ParentID = categoryUpdate.ParentID,
                KeywordID=categoryUpdate.KeywordID,
                KeywordName=categoryUpdate.KeywordName
            };
        }
    }
}
