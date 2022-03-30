using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordUpdate")]
    public class KeywordUpdateViewComponent: ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordUpdateViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var key = keywordApplication.UpdateGet(id);
            return View(key);
        }
    }
}
