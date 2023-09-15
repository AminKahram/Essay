using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordDrp")]
    public class KeywordDrpViewComponent : ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordDrpViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke(string KeywordName)
        {
            var keyword = keywordApplication.GetDrp(KeywordName);
            return View(keyword);
        }
    }
}
