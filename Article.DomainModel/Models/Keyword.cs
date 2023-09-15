using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Models
{
    public class Keyword
    {
        public int KeywordID { get; set; }
        public string KeywordName { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Article> Articles { get; set; }

        public Keyword()
        {
            this.Articles = new List<Article>();
            this.Categories = new List<Category>();

        }
    }
}
