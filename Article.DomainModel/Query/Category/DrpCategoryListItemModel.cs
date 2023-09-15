using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Category
{
    public class DrpCategoryListItemModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public int? ParentID { get; set; }
        public bool IsRoot { get; set; }
        public bool HasChildren { get; set; }
    }
}
