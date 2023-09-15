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
    class ProjectActionConfiguration : IEntityTypeConfiguration<ProjectAction>
    {
        public void Configure(EntityTypeBuilder<ProjectAction> builder)
        {
            builder.Property(x => x.ProjectActionName).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.RoleActions).WithOne(x => x.ProjectAction).HasForeignKey(x => x.ProjectActionID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
