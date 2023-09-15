using Microsoft.AspNetCore.Http;
using Security.Application.Services;
using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AuthenticationProperties = Microsoft.AspNetCore.Authentication.AuthenticationProperties;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Implementation
{
    public class AuthHelper :IAuthHelper
    {
        private readonly IHttpContextAccessor contextAccessor;
        public AuthHelper(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public UserInfo GetCurrentUserInfo()
        {
            if (contextAccessor.HttpContext.User.Claims.FirstOrDefault() == null)
            {
                return new UserInfo();
            }
            var claims = contextAccessor.HttpContext.User.Claims.ToList();
            var RoleID =int.Parse(claims.First(x => x.Type == "RoleID").Value);
            var RoleName = claims.First(x => x.Type == "RoleName").Value;
            var UserID = int.Parse(claims.First(x => x.Type == "UserID").Value);
            var UserName = claims.First(x => x.Type == ClaimTypes.Name).Value;
            var FullName = claims.First(x => x.Type == "FullName").Value;
            return new UserInfo { UserID = UserID, UserName = UserName, RoleID = RoleID, RoleName = RoleName, FullName = FullName };
        }

        public void SignIn(UserInfo userInfo)
        {
            var claims = new List<Claim>
            {
                new Claim("RoleID",userInfo.RoleID.ToString())
                ,new Claim("RoleName",userInfo.RoleName)
                ,new Claim("UserID",userInfo.UserID.ToString())
                ,new Claim(ClaimTypes.Name,userInfo.UserName)
                ,new Claim("FullName",userInfo.FullName)
            };
            var claimIdetity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authproperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                IsPersistent = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20)
            };
            contextAccessor.HttpContext
                .SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                , new ClaimsPrincipal(claimIdetity), authproperties);
        }
     


        public void SignOut()
        {
            contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
