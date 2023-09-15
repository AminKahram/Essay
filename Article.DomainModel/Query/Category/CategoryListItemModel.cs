using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Category
{
    public class CategoryListItemModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ParentName { get; set; }
        public int Articles { get; set; }
    }
}
