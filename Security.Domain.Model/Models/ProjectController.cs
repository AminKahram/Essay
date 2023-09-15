using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Model.Models
{
    public class ProjectController
    {
        public int ProjectControllerID { get; set; }
        public string ProjectControllerName { get; set; }
        public virtual int ProjectAreaID { get; set; }
        public virtual ProjectArea ProjectArea { get; set; }
        public virtual ICollection<ProjectAction> ProjectActions { get; set; }
        public ProjectController()
        {
            this.ProjectActions = new List<ProjectAction>();
        }
    }
}
