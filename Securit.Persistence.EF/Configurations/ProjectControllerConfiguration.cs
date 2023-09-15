using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Security.Domain.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securit.Persistence.EF.Configurations
{
    class ProjectControllerConfiguration : IEntityTypeConfiguration<ProjectController>
    {
        public void Configure(EntityTypeBuilder<ProjectController> builder)
        {
            builder.Property(x => x.ProjectControllerName).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.ProjectActions).WithOne(x => x.ProjectController).HasForeignKey(x => x.ProjectControllerID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
