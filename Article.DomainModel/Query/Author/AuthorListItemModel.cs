using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Author
{
    public class AuthorListItemModel
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int ArticleCount { get; set; }
    }
}
