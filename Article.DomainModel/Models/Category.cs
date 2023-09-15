using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public virtual int? ParentID { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Keyword> Keywords  { get; set; }
        public Category()
        {
            this.Keywords = new List<Keyword>();
            this.Children = new List<Category>();
            this.Articles = new List<Article>();
        }
    }
}
