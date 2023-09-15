using Framework.Services.BaseServiceModel;
using Security.Domain.Model.Models;
using Security.Domain.Model.Query;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securit.Persistence.EF.DomainRrepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly SecurityContext db;
        public AccountRepository(SecurityContext db)
        {
            this.db = db;
        }

        public bool CheckforPermission(CheckPermission checkPermission)
        {
            var q = from C in db.ProjectControllers
                    join A in db.ProjectActions on C.ProjectControllerID equals A.ProjectControllerID
                    join RA in db.RoleActions on A.ProjectActionID equals RA.ProjectActionID
                    join R in db.Roles on RA.RoleID equals R.RoleID
                    join U in db.Users on R.RoleID equals U.RoleID
                    select new
                    {
                         ControllerName=C.ProjectControllerName,
                         ActionName =A.ProjectActionName,
                         UserName=U.UserName,
                         HasPermission=RA.HasPermission
                    };
            var r = q.FirstOrDefault(x => x.ActionName == checkPermission.ActionName && x.ControllerName == checkPermission.ControllerName && x.UserName == checkPermission.UserName && x.HasPermission==true);
            if (r == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public User GetFullInfo(string UserName)
        {
            return db.Users.FirstOrDefault(x => x.UserName == UserName);
            
        }

        public UserInfo GetUserInfo(string UserName)
        {
            var q= from R in db.Roles
                    join U in db.Users on R.RoleID equals U.RoleID
                    where U.UserName == UserName
                    select new UserInfo
                    {
                        RoleID = R.RoleID,
                        RoleName = R.RoleName,
                        FullName = U.FirstName + " " + U.LastName,
                        UserID = U.UserID,
                        UserName = U.UserName
                    };
            return q.FirstOrDefault();
        }

        public OperationResult RegisterNewUser(User user)
        {
            OperationResult op = new OperationResult(OperationState.CurrentState.Add);
            try
            {
                var q = db.Users.Any(x => x.UserName == user.UserName);
                if (q)
                {
                    return op.Failed("There is already an user wuth this username ");
                }
                db.Users.Add(user);
                db.SaveChanges();
                return op.Succeeded(user.UserID,"User Added successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("User failed to add " + ex.Message);
            }
        }
        public OperationResult Update(User Current)
        {
            OperationResult op = new OperationResult(Current.UserID,OperationState.CurrentState.Update);
            try
            {
                var useru = GetUserUpdate(Current.UserID);
                useru.UserName = Current.UserName;
                useru.RoleID = Current.RoleID;
                useru.Email = Current.Email;
                useru.FirstName = Current.FirstName;
                useru.LastName = Current.LastName;
                useru.PhoneNumber = Current.PhoneNumber;

                db.Users.Attach(useru);
                db.Entry<User>(useru).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return op.Succeeded("User updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("User failed to update " + ex.Message);
            }
        }
        public OperationResult UpdatePassword(UserPasswordInfoModel passwordUpdate)
        {
            OperationResult op = new OperationResult(passwordUpdate.UserID, OperationState.CurrentState.Update);
            try
            {
                var useru = GetUserUpdate(passwordUpdate.UserID);
                useru.Password = passwordUpdate.Password;
                db.Users.Attach(useru);
                db.Entry<User>(useru).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return op.Succeeded("User updated successfully");
            }
            catch (Exception ex)
            {
                return op.Failed("User failed to update " + ex.Message);
            }
        }
        private User GetUserUpdate(int ID)
        {
            return db.Users.FirstOrDefault(x => x.UserID == ID);
        }
        public UserPasswordInfoModel GetPasswordInfo(int ID)
        {
            return db.Users.Select(x => new UserPasswordInfoModel { UserID = x.UserID, Password = x.Password }).FirstOrDefault(x => x.UserID == ID);
        }
        public UserItemModel Get(int ID)
        {
            return db.Users.Select(x => new UserItemModel
            {
                UserID = x.UserID,
                UserName = x.UserName,
                Email = x.Email,
                RoleID = x.RoleID,
                RoleName = x.Role.RoleName,
                PhoneNumber = x.PhoneNumber,
                //Password = x.Password,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).FirstOrDefault(x => x.UserID == ID);
            
        }

        
    }
}
