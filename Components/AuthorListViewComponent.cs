using Article.Application.Service;
using Article.DomainModel.Query.Author;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components
{
    [ViewComponent(Name = "AuthorList")]
    public class AuthorListViewComponent: ViewComponent
    {
        private readonly IAuthorApplication authorApplication;
        public AuthorListViewComponent(IAuthorApplication authorApplication)
        {
            this.authorApplication = authorApplication;
        }
        public IViewComponentResult Invoke(AuthorSearchModel sm)
        {
            int rc ;
            var auth = authorApplication.Search(sm, out rc);
            sm.RecordCount = rc;
            if (sm.RecordCount % sm.PageSize == 0)
            {
                sm.PageCount = sm.RecordCount / sm.PageSize;
            }
            else
            {
                sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            }
            TempData["PageCountAuthor"] = sm.PageCount;

            //ViewBag.sm = sm;
            return View(auth);
        }
    }
}
