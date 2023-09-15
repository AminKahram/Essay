using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Article
{
    public class ArticleUpdateItemModel
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
        public int ParentID { get; set; }

        public int CategoryID { get; set; }

        public string AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string KeywordID { get; set; }
        public string KeywordName { get; set; }
    } 
}
