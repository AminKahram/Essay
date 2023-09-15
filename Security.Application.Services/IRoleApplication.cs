using Security.Domain.Model.Query;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Services
{
    public interface IRoleApplication
    {
        List<DrpRoleModel> GetRoles();
    }
}
