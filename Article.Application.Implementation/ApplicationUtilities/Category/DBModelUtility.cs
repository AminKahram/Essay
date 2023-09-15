using Article.Application.Model.Models.AddEditModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Category
{
    public class DBModelUtility
    {
        public static DomainModel.Models.Category ToDB(CategoryAddEditModel categoryAddEdit)
        {
            return new DomainModel.Models.Category
            {
                CategoryID = categoryAddEdit.CategoryID,
                CategoryName = categoryAddEdit.CategoryName,
                ParentID = categoryAddEdit.ParentID,
                Slug=categoryAddEdit.Slug
            };
        }
    }
}
