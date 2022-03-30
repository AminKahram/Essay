using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.CategoryComponents
{
    [ViewComponent(Name = "CategoryUpdate")]
    public class CategoryUpdateViewComponent : ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public CategoryUpdateViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var cat = categoryApplication.UpdateGet(id);

            return View(cat);
        }

    }
}
