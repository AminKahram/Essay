using Article.Application.Service;
using Essay.Models.Utilities.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components
{
    [ViewComponent(Name = "SubCategoryDrp")]
    public class SubCategoryDrpViewComponent : ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public SubCategoryDrpViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke(int ParentID)
        {
            var cat = DrpCategoryListItemModelToViewUtility.ToView(categoryApplication.GetChildren(ParentID));
            //cat.Insert(0, new Article.DomainModel.Query.Category.DrpCategoryListItemModel { CategoryID = -1, CategoryName = "Select" });
            //SelectList subcat = new SelectList(cat, "CategoryID", "CategoryName");

            //ViewBag.subcat = subcat;
            return View(cat);
        }
    }
}
