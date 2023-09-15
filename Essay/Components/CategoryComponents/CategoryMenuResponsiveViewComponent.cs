using Article.Application.Service;
using Article.DomainModel.Query.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.CategoryComponents
{
    [ViewComponent(Name = "CategoryMenuResponsive")]
    public class CategoryMenuResponsiveViewComponent: ViewComponent
    {
        private readonly ICategoryApplication categoryApplication;
        public CategoryMenuResponsiveViewComponent(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IViewComponentResult Invoke()
        {
            List<CategoryMenuItemModel> Cats = new List<CategoryMenuItemModel>();

            var roots = categoryApplication.GetRoots();
            foreach (var rootprop in roots)
            {
                CategoryMenuItemModel Layer1 = new CategoryMenuItemModel { CategoryID = rootprop.CategoryID, CategoryName = rootprop.CategoryName, Slug = rootprop.Slug };
                var childs = categoryApplication.GetChildren(Layer1.CategoryID);
                foreach (var childprop in childs)
                {
                    CategoryMenuItemModel Layer2 = new CategoryMenuItemModel { CategoryID = childprop.CategoryID, CategoryName = childprop.CategoryName, Slug = childprop.Slug, ParentID = childprop.ParentID };
                    Layer1.Children.Add(Layer2);
                }
                Cats.Add(Layer1);
            }
            return View(Cats);
        }
    }
}

