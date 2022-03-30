using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordListForArticle")]
    public class KeywordListForArticleViewComponent: ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordListForArticleViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var keys = keywordApplication.GetKeywordsForArticle(id);
            return View(keys);
        }
    }
}
