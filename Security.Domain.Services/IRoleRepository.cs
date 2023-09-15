using Security.Domain.Model.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Services
{
    public interface IRoleRepository
    {
        List<DrpRoleModel> GetRoles();

    }
}
