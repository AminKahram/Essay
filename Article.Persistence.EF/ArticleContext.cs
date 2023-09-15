using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Article.DomainModel.Models;
using Article.Persistence.EF.Configurations;

namespace Article.Persistence.EF
{
    public class ArticleContext:DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options):base(options)
        {

        }
        public DbSet<Article.DomainModel.Models.Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        //public DbSet<KeywordArticle> keywordArticles { get; set; }
        //public DbSet<KeywordCategory> keywordCategories { get; set; }
        //public DbSet<ArticleAuthors> articleAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Article.DomainModel.Models.Article>(configuration:new ArticleConfiguration());
            modelBuilder.ApplyConfiguration<Author>(configuration:new AuthorConfiguration());
            modelBuilder.ApplyConfiguration<Category>(configuration:new CategoryConfiguraton());
            modelBuilder.ApplyConfiguration<Keyword>(configuration:new KeywordConfiguration());
            //modelBuilder.Entity<Article.DomainModel.Models.Article>().HasMany(x => x.Authors).WithMany(x => x.Articles)
            // .UsingEntity(x =>
            // {
            //     x.("ProductCategoryID");
            //     x.MapRightKey("ProductID");
            //     x.ToTable("pc");
            // });
            base.OnModelCreating(modelBuilder);
        }
    }
}
