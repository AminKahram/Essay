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
    class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.RoleName).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.Users).WithOne(x => x.Role).HasForeignKey(x => x.RoleID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.RoleActions).WithOne(x => x.Role).HasForeignKey(x => x.RoleID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
