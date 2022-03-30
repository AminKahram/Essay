using Article.Application.Model.Models.AddEditModels.Article;
using Article.Application.Service;
using Essay.Models.Utilities.Article;
using Framework.File;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.ArticlesComponents
{
    [ViewComponent(Name = "ArticleUpdate")]
    public class ArticleUpdateViewComponent : ViewComponent
    {
        private readonly IArticleApplication articleApplication;
        private readonly IWebHostEnvironment hostEnvironment;

        public ArticleUpdateViewComponent(IArticleApplication articleApplication, IWebHostEnvironment hostEnvironment)
        {
            this.articleApplication = articleApplication;
            this.hostEnvironment = hostEnvironment;
        }
        public IViewComponentResult Invoke(int ID)
        {
            var ug = ArticleEditViewModelUtility.ToEditModel(articleApplication.UpdateGet(ID));
            var pathimg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Photos/Article/", ug.ArticleImageName);
            var pathfile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/PDFs/", ug.ArticleFileName);

            //string test = hostEnvironment.WebRootPath;

            if (!System.IO.File.Exists(pathimg))
            {
                ug.ArticleImageName = null;
            }
            if (!System.IO.File.Exists(pathfile))
            {
                ug.ArticleFileName = null;
            }

            return View(ug);
        }
    }
}
