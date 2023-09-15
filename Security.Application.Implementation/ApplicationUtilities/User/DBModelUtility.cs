using Security.Application.Model.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Implementation.ApplicationUtilities.User
{
    public class DBModelUtility
    {
        public static Domain.Model.Models.User ToDB(UserModel user)
        {
            return new Domain.Model.Models.User
            {
                UserID = user.UserID,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                RoleID = user.RoleID
            };
        }
        public static Domain.Model.Models.User ToEditDB(UserUpdateModel user)
        {
            return new Domain.Model.Models.User
            {
                UserID = user.UserID,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                RoleID = user.RoleID
            };
        }
    }
}
