using Microsoft.EntityFrameworkCore;
using Securit.Persistence.EF.Configurations;
using Security.Domain.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securit.Persistence.EF
{
    public class SecurityContext:DbContext
    {
        public SecurityContext(DbContextOptions<SecurityContext> options):base(options)
        {

        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RoleAction> RoleActions { get; set; }
        public DbSet<ProjectAction> ProjectActions { get; set; }
        public DbSet<ProjectController> ProjectControllers { get; set; }
        public DbSet<ProjectArea> ProjectAreas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Role>(configuration: new RoleConfiguration());
            modelBuilder.ApplyConfiguration<User>(configuration: new UserConfiguration());
            modelBuilder.ApplyConfiguration<ProjectAction>(configuration: new ProjectActionConfiguration());
            modelBuilder.ApplyConfiguration<ProjectController>(configuration: new ProjectControllerConfiguration());
            modelBuilder.ApplyConfiguration<ProjectArea>(configuration: new ProjectAreaConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
