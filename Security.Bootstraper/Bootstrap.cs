using Framework.Security;
using Framework.Security.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Securit.Persistence.EF.DomainRrepository;
using Security.Application.Implementation;
using Security.Application.Services;
using Security.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Security.Bootstraper
{
    public static class Bootstrap
    {
        public static void WireUp(IServiceCollection services,string ConnectionString)
        {
            services.AddDbContext<Securit.Persistence.EF.SecurityContext>(OptionAction => OptionAction.UseSqlServer(ConnectionString), ServiceLifetime.Scoped);
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IAccountApplication, AccountApplication>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IRoleApplication, RoleApplication>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IAuthHelper, AuthHelper>();
            services.AddHttpContextAccessor();
        }
    }
}
