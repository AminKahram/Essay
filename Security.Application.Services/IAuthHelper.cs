using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Services
{
    public interface IAuthHelper
    {
        void SignIn(UserInfo userInfo);
        void SignOut();
        UserInfo GetCurrentUserInfo();
    }
}
