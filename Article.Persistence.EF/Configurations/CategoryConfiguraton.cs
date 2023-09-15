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
    public class CategoryConfiguraton : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(200).IsRequired();

            builder.HasMany(x => x.Children).WithOne(x => x.Parent).HasForeignKey(x => x.ParentID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Articles).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.Keywords).WithMany(x=>x.Categories).UsingEntity(j => j.ToTable("CategoryKeywords"));

            //builder.HasMany(x => x.KeywordCategories).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
