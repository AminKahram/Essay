using Framework.Security.Services;
using Framework.Services.BaseServiceModel;
using Security.Application.Implementation.ApplicationUtilities.User;
using Security.Application.Model.Account;
using Security.Application.Services;
using Security.Domain.Model.Models;
using Security.Domain.Model.Query;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Implementation
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IAccountRepository accountRepository;
        private readonly IAuthHelper authHelper;
        private readonly IPasswordHasher passwordHasher;
        public AccountApplication(IAccountRepository accountRepository, IAuthHelper authHelper, IPasswordHasher passwordHasher)
        {
            this.authHelper = authHelper;
            this.accountRepository = accountRepository;
            this.passwordHasher = passwordHasher;
        }
        public bool CheckForPermission(CheckPermission permission)
        {
            return accountRepository.CheckforPermission(permission);
        }

        public UserItemModel Get(int ID)
        {
            return accountRepository.Get(ID);
        }

        public UserInfo GetAccoountInfo()
        {
            return authHelper.GetCurrentUserInfo();
        }
 
        public OperationResult Login(LogginModel logginModel)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.LogIn);
            var u = accountRepository.GetFullInfo(logginModel.UserName);
            if (u == null)
            {
                return op.Failed("Credential Failed");
            }
            var (Verified,needsUpgrade) = passwordHasher.Check(u.Password, logginModel.Password);
            if ( !Verified)
            {
                return op.Failed("Credential Failed");
            }
            var ui = accountRepository.GetUserInfo(u.UserName);
            authHelper.SignIn(ui);
            return op.Succeeded(ui.UserID,"Logged in Successfully");
        }

        public void LogOutUser()
        {
            authHelper.SignOut();
        }

        public OperationResult Register(UserModel user)
        {
            return accountRepository.RegisterNewUser(DBModelUtility.ToDB(user));
        }
        public OperationResult Update(UserUpdateModel user)
        {
            return accountRepository.Update(DBModelUtility.ToEditDB(user));
        }

        public OperationResult UpdatePassword(PasswordUpdateModel passwordUpdate)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Update);
            try
            {
                var u = accountRepository.GetPasswordInfo(passwordUpdate.UserID);
                if (u == null)
                {
                    return op.Failed("Credential Failed");
                }
                var (Verified, needsUpgrade) = passwordHasher.Check(u.Password, passwordUpdate.PastPassword);
                if (!Verified)
                {
                    return op.Failed("Credential Failed");
                }
                u.Password = passwordHasher.Hash(passwordUpdate.Password);
                return accountRepository.UpdatePassword(u);
                //return op.Succeeded(passwordUpdate.UserID, "Password updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("Password update failed " + ex.Message);
            }

        }
    }
}
