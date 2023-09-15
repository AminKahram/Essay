using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Article
{
    public class ArticleListItemModel 
    {
        public int ArticleID { get; set; }
        public string ArticleSubject { get; set; }
        public string SmallDescription { get; set; }
        public string AuthorName { get; set; }
        public string KeywordName { get; set; }
        public int Size { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ArticlImageName { get; set; }
        public string ArticlFileName { get; set; }
        //public int AuthorID { get; set; }

    }
}
