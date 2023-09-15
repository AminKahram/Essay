﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.DomainModel.Query.Author
{
    public class AuthorListItemForArticleModel
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int ArticleID { get; set; }
    }
}