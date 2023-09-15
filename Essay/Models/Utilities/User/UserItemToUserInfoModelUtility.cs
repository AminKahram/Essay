using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Models.Utilities.User
{
    public class UserItemToUserInfoModelUtility
    {
        public static UserInfo ToUserInfoDropDown(UserItemModel userItem)
        {
            return new UserInfo
            {
                UserName = userItem.UserName,
                RoleName = userItem.RoleName,
                FullName = userItem.FirstName + " " + userItem.LastName
            };
        }
        public static UserInfo ToUserInfoSideBar(UserItemModel userItem)
        {
            return new UserInfo
            {
                UserName = userItem.UserName
            };
        }
        
    }
}
