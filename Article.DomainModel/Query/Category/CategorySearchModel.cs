using Framework.DomainModel.BaseDomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Category
{
    public class CategorySearchModel:PageModel
    {
        public string CategoryName { get; set; }
        //public int? KeywordID { get; set; }
    }
}
