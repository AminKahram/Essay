using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.ArticlesComponents
{
    [ViewComponent(Name = "ArticleClientItem")]
    public class ArticleClientItemViewComponent: ViewComponent
    {
        private readonly IArticleApplication articleApplication;
        public ArticleClientItemViewComponent(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }
        public IViewComponentResult Invoke(int ID)
        {
            //var art = articleApplication.Get(ID);
            //return View(art);
            var art = articleApplication.GetClientArticle(ID);
            return View(art);
        }
    }
}
