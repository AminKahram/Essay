using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
       // public virtual ICollection<ArticleAuthors> ArticleAuthors { get; set; }

        public Author()
        {
            this.Articles = new List<Article>();
           // this.ArticleAuthors = new List<ArticleAuthors>();

        }
    }
}
