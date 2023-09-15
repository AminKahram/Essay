using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components
{
    [ViewComponent(Name = "AuthorDrp")]
    public class AuthorDrpViewComponent: ViewComponent
    {
        private readonly IAuthorApplication authorApplication;
        public AuthorDrpViewComponent(IAuthorApplication authorApplication)
        {
            this.authorApplication = authorApplication;
        }
        public IViewComponentResult Invoke(string AuthorName)
        {
            var q = authorApplication.GetDrp(AuthorName);
            return View(q);
        }
    }
}
