using Article.Application.Model.Models.AddEditModels.Keyword;
using Article.Application.Service;
using Article.DomainModel.Query.Author;
using Article.DomainModel.Query.Keyword;
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
    public class KeywordManagementController : Controller
    {
        private readonly IKeywordApplication keywordApplication;
        public KeywordManagementController(IKeywordApplication keywordApplication)
        {
            this.keywordApplication = keywordApplication;
        }
        public IActionResult Index(KeywordSearchModel sm)
        {

            return View(sm);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return ViewComponent("KeywordAdd");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(KeywordAddEditModel keywordAdd)
        {
            var op = new OperationResult(OperationState.CurrentState.Add);

            if (ModelState.IsValid)
            {
                op = keywordApplication.Add(keywordAdd);
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
            var op = keywordApplication.Delete(id);
            return new JsonResult(op);
        }
        public IActionResult Update(int id)
        {
            return ViewComponent("KeywordUpdate", id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(KeywordAddEditModel keywordAddEdit)
        {
            var op = new OperationResult(OperationState.CurrentState.Update);

            if (ModelState.IsValid)
            {
               
                op = keywordApplication.Update(keywordAddEdit);
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

        public IActionResult Search(KeywordSearchModel sm)
        {
            return ViewComponent("KeywordList", sm);
        }
        public IActionResult DrpSearch(string KeywordName)
        {
            return ViewComponent("KeywordDrp", KeywordName);
        }

    }
}
