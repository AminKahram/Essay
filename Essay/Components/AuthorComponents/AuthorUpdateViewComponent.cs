using Article.Application.Service;
using Article.DomainModel.Query.Author;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.AuthorComponents
{
    [ViewComponent(Name = "AuthorUpdate")]
    public class AuthorUpdateViewComponent : ViewComponent
    {
        private readonly IAuthorApplication authorApplication;
        public AuthorUpdateViewComponent(IAuthorApplication authorApplication)
        {
            this.authorApplication = authorApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            //AuthorSearchModel sm = new AuthorSearchModel { AuthorID = id, AuthorName = null };
            //int rc;
            //var auth = authorApplication.Search(sm, out rc);
            //sm.RecordCount = rc;
            //if (sm.RecordCount % sm.PageSize == 0)
            //{
            //    sm.PageCount = sm.RecordCount / sm.PageSize;
            //}
            //else
            //{
            //    sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            //}
            //ViewBag.sm = sm;
            var auth = authorApplication.GetAuthorForUpdate(id);

            return View(auth);
        }
    }
}
