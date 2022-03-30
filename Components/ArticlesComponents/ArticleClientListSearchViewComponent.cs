using Article.Application.Service;
using Article.DomainModel.Query.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.ArticlesComponents
{
    [ViewComponent(Name = "ArticleClientListSearch")]
    public class ArticleClientListSearchViewComponent : ViewComponent
    {
        private readonly IArticleApplication articleApplication;
        public ArticleClientListSearchViewComponent(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }
        public IViewComponentResult Invoke(/*ArticleSearchModel sm*/)
        {
            //if (sm != null)
            //{
            //    int rc;

            //    var art = articleApplication.GetClientArticles(sm, out rc);
            //    sm.RecordCount = rc;
            //    if (sm.RecordCount % sm.PageSize == 0)
            //    {
            //        sm.PageCount = sm.RecordCount / sm.PageSize;
            //    }
            //    else
            //    {
            //        sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            //    }
            //    TempData["PageCountArticleClient"] = rc;
            //    //ViewBag.PageCount = sm.PageCount;
            //    //ViewBag.sm = sm;
            //    return View(art);
            //}
            //else
            //{
                return View();
            //}
        }
    }
}
