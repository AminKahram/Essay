﻿using Essay.Helper;
using Essay.Models.Utilities.User;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Services;
using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.UserComponets
{

    [ViewComponent(Name = "UserInfoDropDown")]
    public class UserInfoDropDownViewComponent: ViewComponent
    {
        private readonly IAccountApplication accountApplication;
        public UserInfoDropDownViewComponent(IAccountApplication accountApplication)
        {
            this.accountApplication = accountApplication;
        }
        public IViewComponentResult Invoke()
        {
            var ID = accountApplication.GetAccoountInfo().UserID;
            var user = UserItemToUserInfoModelUtility.ToUserInfoDropDown(accountApplication.Get(ID));

            //UserInfo user;
            //if (ID != 0)
            //{
            //     user =UserItemToUserInfoModelUtility.ToUserInfoDropDown(accountApplication.Get(ID));
            //}
            ////else
            //{
            //    //ID = accountApplication.GetAccoountInfo().UserID;
            //    //user = UserItemToUserInfoModelUtility.ToUserInfoDropDown(accountApplication.Get(ID));
            //    user = null;
            //    //return View();
            //}
            return View(user);
        }
    }
}
