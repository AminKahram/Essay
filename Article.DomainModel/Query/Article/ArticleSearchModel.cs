using Framework.DomainModel.BaseDomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Article
{
    public class ArticleSearchModel:PageModel
    {
        public string ArticleSubject { get; set; }
        public int? KeywordSelected { get; set; }
        public int? AuthorID { get; set; }
        public int? CategoryID { get; set; }
    }
}
