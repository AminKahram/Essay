using Article.Application.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.CategoryComponents
{
    [ViewComponent(Name = "SubCategoryForUpdate")]
    public class SubCategoryForUpdateViewComponent: ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public SubCategoryForUpdateViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke(int CategoryID)
        {
            var cats = categoryApplication.GetUpdateCategoryDrp(CategoryID);
            return View(cats);
        }
    }
}
