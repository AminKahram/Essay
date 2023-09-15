using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Keyword
{
    public class KeywordListItemForCategoryModel
    {
        public int KeywordID { get; set; }
        public string KeywordName { get; set; }
        public int CategoryID { get; set; }

    }
}
