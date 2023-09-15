using Article.DomainModel.Query.Category;
using Essay.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Models.Utilities.Category
{
    public class DrpCategoryListItemModelToViewUtility
    {
        public static List<DrpCategoryListItemView> ToView(List<DrpCategoryListItemModel> drpCategory)
        {
            return drpCategory.Select(x => new DrpCategoryListItemView { CategoryID = x.CategoryID, CategoryName = x.CategoryName }).ToList();

            
        }
    }
}
