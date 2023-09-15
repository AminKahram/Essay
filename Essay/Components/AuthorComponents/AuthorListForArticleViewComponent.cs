using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.AuthorComponents
{
    [ViewComponent(Name = "AuthorListForArticle")]
    public class AuthorListForArticleViewComponent: ViewComponent
    {
        private readonly IAuthorApplication authorApplication;
        public AuthorListForArticleViewComponent(IAuthorApplication authorApplication)
        {
            this.authorApplication = authorApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var auts = authorApplication.GetAuthorsListForArticle(id);
            return View(auts);
        }
    }
}
