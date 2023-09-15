using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.CategoryComponents
{
    [ViewComponent(Name = "CategoryRoot")]
    public class CategoryRootViewComponent: ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public CategoryRootViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke()
        {
            var catroot = categoryApplication.GetRoots();
            return View(catroot);
        }
    }
}
