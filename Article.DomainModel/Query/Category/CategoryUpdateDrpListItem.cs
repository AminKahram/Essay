using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Category
{
    public class CategoryUpdateDrpListItem
    {
        public int ParentID { get; set; }
        public string ParentName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
