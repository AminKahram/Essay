using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordDrpSearch")]
    public class KeywordDrpSearchViewComponent: ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordDrpSearchViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke()
        {
            var keyword = keywordApplication.GetAll();
            return View(keyword);
        }
    }
}
