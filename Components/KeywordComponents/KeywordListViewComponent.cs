using Article.Application.Service;
using Article.DomainModel.Query.Keyword;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordList")]
    public class KeywordListViewComponent : ViewComponent
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordListViewComponent(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IViewComponentResult Invoke(KeywordSearchModel sm)
        {
           
            int rc;
            var keyword = keywordApplication.Search(sm, out rc);
            sm.RecordCount = rc;
            if (sm.RecordCount % sm.PageSize == 0)
            {
                sm.PageCount = sm.RecordCount / sm.PageSize;
            }
            else
            {
                sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            }
            //ViewBag.sm = sm;
            TempData["PageCountKeyword"] = sm.PageCount;

            return View(keyword);
        }
    }
}
