using Article.Application.Service;
using Article.DomainModel.Query.Article;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.ArticlesComponents
{
    [ViewComponent(Name = "ArticleList")]
    public class ArticleListViewComponent : ViewComponent
    {
        private readonly IArticleApplication articleApplication;
        public ArticleListViewComponent(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }
        public IViewComponentResult Invoke(ArticleSearchModel sm)
        {
           
            int rc;
            var art = articleApplication.Search(sm, out rc);
            //List<string> paths = new List<string>();
            //foreach (var item in art)
            //{
            //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Photos/Article/", item.ArticlImageName);

            //    paths.Add(path);

             
            //}
            //foreach (var item in paths)
            //{
            //    if (!System.IO.File.Exists(item))
            //    { }
            //}
            
                sm.RecordCount = rc;
            if (sm.RecordCount % sm.PageSize == 0)
            {
                sm.PageCount = sm.RecordCount / sm.PageSize;
            }
            else
            {
                sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            }
            TempData["PageCountArticle"] = sm.PageCount;
            //ViewBag.PageCount = sm.PageCount;
            //ViewBag.sm = sm;
            return View(art);
        }
    }
}
