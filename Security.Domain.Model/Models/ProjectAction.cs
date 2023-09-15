using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Model.Models
{
    public class ProjectAction
    {
        public int ProjectActionID { get; set; }
        public string ProjectActionName { get; set; }
        public virtual int ProjectControllerID { get; set; }
        public virtual ProjectController ProjectController { get; set; }
        public virtual ICollection<RoleAction> RoleActions { get; set; }
        public ProjectAction()
        {
            this.RoleActions = new List<RoleAction>();
        }

    }
}
