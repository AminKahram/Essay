using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Models
{
    public class ArticleAuthors
    {
        public virtual int ArticleID { get; set; }
        public virtual Article Article { get; set; }
        public virtual int AuthorID { get; set; }
        public virtual Author Author{ get; set; }
    }
}
