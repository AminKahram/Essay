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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorID);
            builder.Property(x => x.AuthorName).HasMaxLength(200).IsRequired();
        
           // builder.HasMany(x => x.ArticleAuthors).WithOne(x => x.Author).HasForeignKey(x => x.AuthorID).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
