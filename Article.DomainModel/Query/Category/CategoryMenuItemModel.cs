using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Category
{
    public class CategoryMenuItemModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public int? ParentID { get; set; }
        public CategoryMenuItemModel Parent { get; set; }
        public List<CategoryMenuItemModel> Children { get; set; }
        public CategoryMenuItemModel()
        {
            this.Children = new List<CategoryMenuItemModel>();
        }
    }
}
