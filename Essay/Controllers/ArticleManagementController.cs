using Article.Application.Model.Models.AddEditModels.Article;
using Article.Application.Service;
using Article.DomainModel.Query.Article;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.File;
using System.IO;
using Essay.ViewModel;
using Essay.Models.Utilities.Article;
using Microsoft.AspNetCore.Hosting;
using Essay.ViewModel.Article;
using Grpc.Core;
using Essay.Helper;
using Framework.Services.BaseServiceModel;

namespace Essay.Controllers
{
    [ServiceFilter(typeof(CustomeAuthenticator))]
    public class ArticleManagementController : Controller
    {
        private readonly IArticleApplication articleApplication;
        private readonly IAuthorApplication authorApplication;
        private readonly IWebHostEnvironment hostEnvironment; 
        public ArticleManagementController(IArticleApplication articleApplication, IAuthorApplication authorApplication, ICategoryApplication categoryApplication, IWebHostEnvironment hostEnvironment)
        {
            this.authorApplication = authorApplication;
            this.articleApplication = articleApplication;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index(ArticleSearchModel sm)
        {
            return View(sm);
        }
        public IActionResult Search(ArticleSearchModel sm)
        {
            return ViewComponent("ArticleList", sm);
        }
        
        public IActionResult ClientSearch(int id)
        {
            return ViewComponent("ArticleClientList", id);
        }
        [HttpGet]
        public IActionResult AddNew()
        {
            return ViewComponent("ArticleAdd");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNew(ArticleAddViewModel art)
        {
            var op = new OperationResult(OperationState.CurrentState.Add);

            if (ModelState.IsValid)
            {
                
                if (art.ArticleImage.Length < 1|| art.ArticleImage.Length > 5242880)
                {
                    op = op.Failed("Image size must be between 10240 & 5242880");
                    //TempData["ErrorMessage"] = "Image size must be between 10240 & 5242880";
                    //return RedirectToAction("AddNew", "ArticleManagement");
                    return new JsonResult(op);

                }
                string imgfn = art.ArticleImage.FileName;
                string filefn = art.ArticleFile.FileName;
                if (!imgfn.IsValidFileName() || !filefn.IsValidFileName())
                {
                    op = op.Failed("Invalid File uploaded");
                    //TempData["ErrorMessage"] = "Invalid File uploaded";
                    //return RedirectToAction("AddNew", "ArticleManagement");
                    return new JsonResult(op);
                }
                if (!imgfn.IsValidImageFileName() || !filefn.IsValidPdfFile())
                {
                    op = op.Failed("Invalid File uploaded");
                    //TempData["ErrorMessage"] = "Invalid File uploaded";
                    //return RedirectToAction("AddNew", "ArticleManagement");
                    return new JsonResult(op);
                }
                op = articleApplication.Add(ArticleAddModelUtility.ToAddModel(art, hostEnvironment), art.AuthorID, art.KeywordID);
                return new JsonResult(op);
            }
            else
            {
                op.Failed("Invalid Model Sate");
                //return RedirectToAction("Index", "ArticleManagement");
                return new JsonResult(op);
            }

        }
        [HttpPost]
        public IActionResult Delete(int id,string imgname)
        {
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Photos/Article/", imgname);
            //DeleteImageFromRoot(path);
            var op = articleApplication.Delete(id);
            return new JsonResult(op);
        }
        public IActionResult Update(int id)
        {
            return ViewComponent("ArticleUpdate", id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ArticleEditViewModel art)
        {
            var op = new OperationResult(OperationState.CurrentState.Update);

            if (ModelState.IsValid)
            {
                if (art.CategoryID == 0)
                {
                    op = op.Failed("Category can't be null");
                    return new JsonResult(op);
                }
                FileStream fsimg= null;
                FileStream fsfile= null;
                if (art.ArticleImage != null)
                {
                    if (art.ArticleImage.Length < 1 || art.ArticleImage.Length > 5242880)
                    {
                        op = op.Failed("Image size must be between 1 & 5242880");
                        return new JsonResult(op);
                        //TempData["ErrorMessage"] = "Image size must be between 10240 & 5242880";
                        //return RedirectToAction("Index", "ArticleManagement");
                    }

                    string imgfn = art.ArticleImage.FileName;
                    if (!imgfn.IsValidFileName())
                    {
                        op = op.Failed("Invalid File uploaded");
                        //TempData["ErrorMessage"] = "Invalid File uploaded";
                        //return RedirectToAction("AddNew", "ArticleManagement");
                        return new JsonResult(op);
                    }
                    if (!imgfn.IsValidImageFileName())
                    {
                        op = op.Failed("Invalid File uploaded");
                        return new JsonResult(op);
                    }
                    var pathimg = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Photos/Article/", art.ArticleImageName);
                    if (System.IO.File.Exists(pathimg) )
                    {
                        DeleteImageFromRoot(pathimg);
                        //TempData["ErrorMessage"] = "Previous image file still exists";
                        ////test and change
                        //return View(art) /*RedirectToAction("Index", "ArticleManagement")*/;
                    }

                    imgfn = System.IO.Path.GetFileName(imgfn);

                    if (imgfn.IsValidFileNameLength())
                    {
                        op = op.Failed("File Name must be at must 133 characters");
                        return new JsonResult(op);
                        //TempData["ErrorMessage"] = "File Name must be at must 133 characters";
                        //return RedirectToAction("Index", "ArticleManagement");
                    }
                    imgfn = imgfn.ToUniqueFileName();

                    string SavigPathimg = hostEnvironment.WebRootPath + @"/Content/Photos/Article/" + imgfn;

                    art.ArticleImageName = imgfn;

                    fsimg = new FileStream(SavigPathimg, FileMode.Create);
                }
                if (art.ArticleFile != null)
                {
                    if (art.ArticleFile.Length < 1 || art.ArticleFile.Length > 50242880)
                    {
                        op = op.Failed("File size must be between 1 & 50242880");
                        return new JsonResult(op);
                    }

                    string filefn = art.ArticleFile.FileName;
                    if (!filefn.IsValidFileName())
                    {
                        op = op.Failed("Invalid File uploaded");
                        //TempData["ErrorMessage"] = "Invalid File uploaded";
                        //return RedirectToAction("AddNew", "ArticleManagement");
                        return new JsonResult(op);
                    }
                    if (!filefn.IsValidPdfFile())
                    {
                        op = op.Failed("Invalid File uploaded");
                        //TempData["ErrorMessage"] = "Invalid File uploaded";
                        //return RedirectToAction("AddNew", "ArticleManagement");
                        return new JsonResult(op);
                    }
                    var pathfile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/PDFs/", art.ArticleFileName);
                    if (System.IO.File.Exists(pathfile) )
                    {
                        DeleteFileFromRoot(pathfile);
                        //TempData["ErrorMessage"] = "Previous image file still exists";
                        ////test and change
                        //return View(art) /*RedirectToAction("Index", "ArticleManagement")*/;
                    }

                    filefn = System.IO.Path.GetFileName(filefn);

                    if (filefn.IsValidFileNameLength())
                    {
                        op = op.Failed("File Name must be at must 133 characters");
                        return new JsonResult(op);
                        //TempData["ErrorMessage"] = "File Name must be at must 133 characters";
                        //return RedirectToAction("Index", "ArticleManagement");
                    }

                    filefn = filefn.ToUniqueFileName();

                    string SavigPathfile = hostEnvironment.WebRootPath + @"/Content/PDFs/" + filefn;

                    art.ArticleFileName = filefn;

                    fsfile = new FileStream(SavigPathfile, FileMode.Create);
                }

                op = articleApplication.Update(ArticleEditViewToAddEditModelUtility.ToAddEditModel(art, hostEnvironment), art.AuthorID, art.KeywordID);
                if (op.Succes)
                {
                    if (fsimg != null)
                    {
                        art.ArticleImage.CopyTo(fsimg);
                        fsimg.Close();
                       
                    }
                    if (fsfile != null)
                    {
                        art.ArticleFile.CopyTo(fsfile);
                        fsfile.Close();
                    }
                    return new JsonResult(op);

                    //return RedirectToAction("Index", "ArticleManagement");
                }
                else
                {
                    TempData["ErrorMessage"] = op.Message;
                    return new JsonResult(op);
                    //return RedirectToAction("Index", "ArticleManagement");
                }

            }
            else
            {
                op.Failed("Invalid Model Sate");
                return new JsonResult(op);
                //TempData["ErrorMessage"] = "Invalid Model State";
                //return RedirectToAction("Index", "ArticleManagement");
            }
        }
        public IActionResult DeleteFileFromRoot(string FilePath)
        {
            if (System.IO.File.Exists(FilePath))
            {
                System.IO.File.Delete(FilePath);
            }
            return new JsonResult("Deleted");
        }
        public IActionResult DeleteImageFromRoot(string FilePath)
        {
            if (System.IO.File.Exists(FilePath))
            {
                System.IO.File.Delete(FilePath);
            }
            return new JsonResult("Deleted");
        }
        public IActionResult GetSubCat(int ParentID)
        {
            return ViewComponent("SubCategoryDrp", new { ParentID = ParentID });
        }
        public IActionResult GetSubForUpdate(int CategoryID)
        {
            return ViewComponent("SubCategoryForUpdate", CategoryID);
        }
        public IActionResult GetKeywords(int id)
        {
            return ViewComponent("KeywordListForArticle", id);
        }
        public IActionResult GetAuthors(int id)
        {
            return ViewComponent("AuthorListForArticle", id);
        }
        public IActionResult DeleteKeywordArticleFromArticle(int ArticleID, int KeywordID)
        {
            var op = articleApplication.DeleteKeywordArticleFromArticle(ArticleID, KeywordID);
            return new JsonResult(op);
        }
        public IActionResult DeleteAuthorArticleFromArticle(int ArticleID, int AuthorID)
        {
            var op = articleApplication.DeleteAuthorArticleFromArticle(ArticleID, AuthorID);
            return new JsonResult(op);
        }
    }
}
        //public IActionResult Test()
        //{
        //    var m= authorApplication.GetAllForDrp();
        //    return View(m);
        //}
