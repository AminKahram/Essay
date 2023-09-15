using Framework.Services.BaseServiceModel;
using Security.Domain.Model.Models;
using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Services
{
    public interface IAccountRepository
    {
        UserInfo GetUserInfo(string UserName);
        User GetFullInfo(string UserName);
        OperationResult RegisterNewUser(User user);
        bool CheckforPermission(CheckPermission checkPermission);
        OperationResult Update(User user);
        OperationResult UpdatePassword(UserPasswordInfoModel passwordUpdate);

        UserItemModel Get(int ID);
        UserPasswordInfoModel GetPasswordInfo(int ID);
    }
}
