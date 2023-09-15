using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleSubject { get; set; }
        public byte[] ArticleImage { get; set; }
        public string ArticleImageName { get; set; }
        public byte[] ArticleFile { get; set; }
        public string ArticleFileName { get; set; }
        public int Size { get; set; }
        public DateTime PublicationDate { get; set; }
        public string SmallDescription { get; set; }
        public string Description { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Keyword> Keywords { get; set; }
       // public virtual ICollection<ArticleAuthors> ArticleAuthors { get; set; }

        //public virtual ICollection<AuthorArticle> AuthorArticles { get; set; }
        //public virtual ICollection<KeywordArticle>  KeywordArticles { get; set; }
        public Article()
        {
            this.Authors = new List<Author>();
            this.Keywords = new List<Keyword>();
          // this.ArticleAuthors = new List<ArticleAuthors>();
        }

    }
}
