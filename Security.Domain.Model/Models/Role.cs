using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Model.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RoleAction> RoleActions { get; set; }
        public Role()
        {
            this.RoleActions = new List<RoleAction>();
            this.Users = new List<User>();
        }
    }
}
