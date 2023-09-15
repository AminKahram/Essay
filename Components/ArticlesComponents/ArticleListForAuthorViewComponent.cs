using Article.Application.Service;
using Article.DomainModel.Query.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.ArticlesComponents
{
    [ViewComponent(Name = "ArticleListForAuthor")]
    public class ArticleListForAuthorViewComponent: ViewComponent
    {
        private readonly IArticleApplication articleApplication;
        public ArticleListForAuthorViewComponent(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var arts = articleApplication.GetAuthorsListForArticle(id);
            return View(arts);
            //ArticleSearchModel  sm = new ArticleSearchModel { AuthorID = id};
            //int rc;
            //var art = articleApplication.Search(sm, out rc);
            //sm.RecordCount = rc;
            //if (sm.RecordCount % sm.PageSize == 0)
            //{
            //    sm.PageCount = sm.RecordCount / sm.PageSize;
            //}
            //else
            //{
            //    sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            //}
            //ViewBag.sm = sm;
            //return View(art);
        }
    }
}

