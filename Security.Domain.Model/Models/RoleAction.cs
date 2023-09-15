using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Model.Models
{
    public class RoleAction
    {
        public int RoleActionID { get; set; }
        public bool HasPermission  { get; set; }
        public virtual int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual int ProjectActionID { get; set; }
        public virtual  ProjectAction ProjectAction { get; set; }
    }
}
