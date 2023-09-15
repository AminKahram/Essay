using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Article
{
    public class ArticleListItemForClientModel
    {
        public int ArticleID { get; set; }
        public string ArticleSubject { get; set; }
        public string ArticlImageName { get; set; }
        public string ArticlFileName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorID { get; set; }
        public int ArticleRecordCount { get; set; }

    }
}
