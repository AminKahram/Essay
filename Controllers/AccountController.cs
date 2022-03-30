using Essay.Helper;
using Framework.Security.Services;
using Framework.Services.BaseServiceModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Model.Account;
using Security.Application.Services;
//using NewsCore.Domain.Commands.User;

namespace NewsCore.Presentation.Controllers
{
    
    public class AccountController : Controller
    {

        private readonly IAccountApplication _accountApplication;
        private readonly IPasswordHasher passwordHasher;

        public AccountController(IAccountApplication accountApplication,IPasswordHasher passwordHasher)
        {
            this.passwordHasher = passwordHasher;
            _accountApplication = accountApplication;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Login(LogginModel command)
        {
            var op = _accountApplication.Login(command);
            var id = _accountApplication.GetAccoountInfo().UserID;

            if (!op.Succes)
            {
                ViewBag.ErrorMessage = op.Message;
                return View(command);
            }
            return RedirectToAction("AdminIndex", "Home");
        }

        public ActionResult LogOut()
        {
            _accountApplication.LogOutUser();
            return RedirectToAction("Login", "Account");
;        }
        [ServiceFilter(typeof(CustomeAuthenticator))]

        public ActionResult Create()
        {
            return View();
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel u)
        {
            u.Password = passwordHasher.Hash(u.Password);

            var op = _accountApplication.Register(u);
            if (op.Succes)
            {
               return RedirectToAction("AdminIndex", "Home");
            }
            else
            {
                return View(u);
            }
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]
        public ActionResult Profile()
        {
            var id = _accountApplication.GetAccoountInfo().UserID;
            if (id != 0)
            {
                return ViewComponent("UserInfo", id);
            }
            else
            {
                //acces denied besh
                return RedirectToAction("Login", "Account");
            }
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]
        public ActionResult UpdatePassword()
        {
            var id = _accountApplication.GetAccoountInfo().UserID;
            if (id != 0)
            {
                return ViewComponent("UserInfoPasswordUpdate");
            }
            else
            {
                //acces denied besh
                return RedirectToAction("Login", "Account");
            }
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePassword(PasswordUpdateModel passwordUpdate)
        {
            var id = _accountApplication.GetAccoountInfo().UserID;
            passwordUpdate.UserID = id;
            var op = new OperationResult(OperationState.CurrentState.Update);
            if (ModelState.IsValid)
            {
                op = _accountApplication.UpdatePassword(passwordUpdate);
                if (op.Succes)
                {
                    //return RedirectToAction("LogOut", "Account");
                    //RedirectToAction("LogOut", "Account");
                  
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
        [ServiceFilter(typeof(CustomeAuthenticator))]
        public ActionResult Update()
        {
            var id = _accountApplication.GetAccoountInfo().UserID;
            if (id != 0)
            {
                return ViewComponent("UserInfoUpdate", id);
            }
            else
            {
                //acces denied besh
                return RedirectToAction("Login", "Account");
            }
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(UserUpdateModel userUpdate)
        {
            var op = new OperationResult(OperationState.CurrentState.Update);
            if (ModelState.IsValid)
            {
                op = _accountApplication.Update(userUpdate);
                if (op.Succes)
                {
                    ViewComponent("UserInfo");
                    ViewComponent("UserInfoDropDown");
                    ViewComponent("UserInfoSideBar");

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

        public ActionResult AccessDenied()
        {
            return View();
        }

    }
}