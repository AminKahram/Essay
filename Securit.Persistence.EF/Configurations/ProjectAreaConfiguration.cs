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
    class ProjectAreaConfiguration : IEntityTypeConfiguration<ProjectArea>
    {
        public void Configure(EntityTypeBuilder<ProjectArea> builder)
        {
            builder.Property(x => x.ProjectAreaName).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.ProjectControllers).WithOne(x => x.ProjectArea).HasForeignKey(x => x.ProjectAreaID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
