using Article.Application.Model.Models.AddEditModels.Category;
using Article.Application.Service;
using Article.DomainModel.Query.Category;
using Essay.Helper;
using Framework.Services.BaseServiceModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    [ServiceFilter(typeof(CustomeAuthenticator))]
    public class CategoryManagementController : Controller
    {
        private readonly ICategoryApplication categoryApplication;
        public CategoryManagementController(ICategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }
        public IActionResult Index(CategorySearchModel sm)
        {
            return View(sm);
        }
        public IActionResult Add()
        {
            return ViewComponent("CategoryAdd");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CategoryAddEditModel categoryAdd)
        {

            var op = new OperationResult(OperationState.CurrentState.Add);

            if (ModelState.IsValid)
            {
                if (categoryAdd.ParentID == 0)
                {
                    categoryAdd.ParentID = null;
                }
                op = categoryApplication.Add(categoryAdd);
                if (op.Succes)
                {
                    return new JsonResult(op);
                }
                else
                {
                    TempData["ErrorMessage"] = op.Message;
                    return new JsonResult(op);
                }

            }
            else
            {
                op = op.Failed("Invalid Model State");

                return new JsonResult(op);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var op = categoryApplication.Delete(id);
            return new JsonResult(op);
        }
        [HttpPost]

        public IActionResult DeleteKeywordCategoryFromCategory(int CategoryID, int KeywordID)
        {
            var op = categoryApplication.DeleteKeywordCategoryFromCategory(CategoryID, KeywordID);
            return new JsonResult(op);
        }
        public IActionResult Search(CategorySearchModel sm)
        {
            return ViewComponent("CategoryList", sm);
        }
        public IActionResult Update(int id)
        {
            return ViewComponent("CategoryUpdate", id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CategoryAddEditModel categoryAddEdit)
        {
            var op = new OperationResult(OperationState.CurrentState.Update);

            if (ModelState.IsValid)
            {
                if (categoryAddEdit.ParentID == 0)
                {
                    categoryAddEdit.ParentID = null;
                }
                op = categoryApplication.Update(categoryAddEdit);
                if (op.Succes)
                {
                    return new JsonResult(op);
                }
                else
                {
                    TempData["ErrorMessage"] = op.Message;
                    return new JsonResult(op);
                }
            }
            else
            {
                op = op.Failed("Invalid Model State");

                return new JsonResult(op);
            }
        }

        public IActionResult GetKeywords(int id)
        {
            return ViewComponent("KeywordListForCategory", id);
        }
    }
}
