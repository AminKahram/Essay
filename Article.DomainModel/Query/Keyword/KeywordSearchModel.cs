using Framework.DomainModel.BaseDomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Keyword
{
    public class KeywordSearchModel:PageModel
    {
        public string KeywordName { get; set; }
    }
}
