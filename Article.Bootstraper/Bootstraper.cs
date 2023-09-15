using Article.Application.Implementation;
using Article.Application.Service;
using Article.Persistence.EF;
using Article.Persistence.EF.DoaminRepository;
using Article.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Article.Bootstraper
{
    public static class Bootstraper
    {
        public static void WireUp(IServiceCollection services,string Connectionstring)
        {
            services.AddDbContext<ArticleContext>(optionsAction => optionsAction.UseSqlServer(Connectionstring), ServiceLifetime.Scoped);
            
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAuthorApplication, AuthorApplication>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryApplication, CategoryApplication>();

            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleApplication, ArticleApplication>();

            services.AddScoped<IKeywordRepository, KeywordRepository>();
            services.AddScoped<IKeywordApplication, KeywordApplication>();
        }
    }
}
