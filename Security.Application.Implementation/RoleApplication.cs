using Security.Application.Services;
using Security.Domain.Model.Query;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Implementation
{
    public class RoleApplication: IRoleApplication
    {
        private readonly IRoleRepository roleRepository;
        public RoleApplication(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public List<DrpRoleModel> GetRoles()
        {
            return roleRepository.GetRoles();
        }
    }
}
