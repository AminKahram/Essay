using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordListForCategory")]
    public class KeywordListForCategoryViewComponent: ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordListForCategoryViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var keys = keywordApplication.GetKeywordsForCategory(id);
            return View(keys);
        }
    }
}
