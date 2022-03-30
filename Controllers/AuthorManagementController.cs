using Article.Application.Model.Models.AddEditModels.Author;
using Article.Application.Service;
using Article.DomainModel.Query.Author;
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
    public class AuthorManagementController : Controller
    {
        private readonly IAuthorApplication authorApplication;
        public AuthorManagementController(IAuthorApplication authorApplication)
        {
            this.authorApplication = authorApplication;
        }
        public IActionResult Index(AuthorSearchModel sm)
        {
            return View(sm);
        }
        public IActionResult Search(AuthorSearchModel sm)
        {
            return ViewComponent("AuthorList", sm);
        }
        public IActionResult DrpSeearch(string AuthorName)
        {
            return ViewComponent("AuthorDrp", AuthorName);
        }
        public IActionResult AddNew()
        {
            return ViewComponent("AuthorAdd");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNew(AuthorAddEditModel authorAdd)
        {
            var op = new OperationResult(OperationState.CurrentState.Add);
            if (ModelState.IsValid)
            {
                op = authorApplication.Add(authorAdd);
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
            var op = authorApplication.Delete(id);
            return new JsonResult(op);
        }
        public IActionResult Update(int id)
        {
            return ViewComponent("AuthorUpdate", id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(AuthorAddEditModel aut)
        {
            var op = new OperationResult(OperationState.CurrentState.Update);
            if (ModelState.IsValid)
            {
                op = authorApplication.Update(aut);
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
        public IActionResult GetArticles(int id)
        {
            return ViewComponent("ArticleListForAuthor", id);
        }
        
    }
}
