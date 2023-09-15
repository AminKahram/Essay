using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Domain.Model.Models
{
    public class ProjectArea
    {
        public int ProjectAreaID { get; set; }
        public string ProjectAreaName { get; set; }
        
        public virtual ICollection<ProjectController> ProjectControllers { get; set; }
        public ProjectArea()
        {
            this.ProjectControllers = new List<ProjectController>();
        }
    }
}
