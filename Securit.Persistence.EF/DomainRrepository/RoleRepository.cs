using Security.Domain.Model.Query;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securit.Persistence.EF.DomainRrepository
{
    public class RoleRepository: IRoleRepository
    {
        private readonly SecurityContext db;
        public RoleRepository(SecurityContext db)
        {
            this.db = db;
        }

        public List<DrpRoleModel> GetRoles()
        {
            //var keywords = from key in db.Roles where key.Articles.Any(x => x.ArticleID == ID) select key.KeywordName;

            return db.Roles.Select(x => new DrpRoleModel { RoleID = x.RoleID, RoleName = x.RoleName }).ToList();
        }
    }
}
