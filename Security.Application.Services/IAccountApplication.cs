using Framework.Services.BaseServiceModel;
using Security.Application.Model.Account;
using Security.Domain.Model.Models;
using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Services
{
    public interface IAccountApplication
    {
        OperationResult Login(LogginModel logginModel);
        UserInfo GetAccoountInfo();
        OperationResult Register(UserModel user);
        bool CheckForPermission(CheckPermission permission);
        void LogOutUser();
        OperationResult Update(UserUpdateModel user);
        OperationResult UpdatePassword(PasswordUpdateModel passwordUpdate);
        UserItemModel Get(int ID);

    }
}
