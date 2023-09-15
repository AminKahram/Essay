using Article.Application.Service;
using Article.DomainModel.Query.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.CategoryComponents
{
    [ViewComponent(Name = "CategoryList")]
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public CategoryListViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke(CategorySearchModel sm)
        {
            int rc;
            var cat = categoryApplication.Search(sm, out rc);
            sm.RecordCount = rc;
            if (sm.RecordCount % sm.PageSize == 0)
            {
                sm.PageCount = sm.RecordCount / sm.PageSize;
            }
            else
            {
                sm.PageCount = sm.RecordCount / sm.PageSize + 1;
            }
            TempData["PageCountCategory"] = sm.PageCount;

            //ViewBag.sm = sm;
            return View(cat);
        }
     }
}
