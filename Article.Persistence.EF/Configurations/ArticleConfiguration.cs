using Article.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article.DomainModel.Models.Article>
    {
        public void Configure(EntityTypeBuilder<DomainModel.Models.Article> builder)
        {
            builder.HasKey(x => x.ArticleID);
            builder.Property(x => x.ArticleFile).IsRequired();
            builder.Property(x => x.ArticleImage).IsRequired();
            builder.Property(x => x.ArticleFileName).HasMaxLength(150).IsRequired();
            builder.Property(x => x.ArticleImageName).HasMaxLength(150).IsRequired();
            builder.Property(x => x.ArticleSubject).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(4000);
            builder.Property(x => x.PublicationDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.SmallDescription).HasMaxLength(500);
            //builder.HasMany(x => x.Authors).WithMany(x => x.Articles).UsingEntity<ArticleAuthors>(
            //    j => j
            //    .HasOne(aut => aut.Author)
            //    .WithMany(artaut => artaut.ArticleAuthors)
            //    .HasForeignKey(autart => autart.AuthorID),
            //    j => j
            //    .HasOne(art => art.Article)
            //    .WithMany(artaut => artaut.ArticleAuthors)
            //    .HasForeignKey(artaut => artaut.ArticleID),
            //    j =>
            //    {
            //        j.HasKey(t => new { t.AuthorID, t.ArticleID });
            //    });

            builder.HasMany(x => x.Keywords).WithMany(x => x.Articles).UsingEntity(j => j.ToTable("ArticleKeywords"));
            builder.HasMany(x => x.Authors).WithMany(x => x.Articles).UsingEntity(j => j.ToTable("ArticleAuthors"));
            //builder.
            //builder.HasMany(x => x.AuthorArticles).WithOne(x => x.Article).HasForeignKey(x => x.ArticleID).OnDelete(DeleteBehavior.ClientCascade);
            //builder.HasMany(x => x.KeywordArticles).WithOne(x => x.Article).HasForeignKey(x => x.ArticleID).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
