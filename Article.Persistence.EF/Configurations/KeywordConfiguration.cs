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
    public class KeywordConfiguration : IEntityTypeConfiguration<Keyword>
    {
        public void Configure(EntityTypeBuilder<Keyword> builder)
        {
            builder.HasKey(x => x.KeywordID);
            builder.Property(x => x.KeywordName).HasMaxLength(200).IsRequired();
          
            //builder.HasMany(x => x.KeywordCategories).WithOne(x => x.Keyword).HasForeignKey(x => x.KeywordID);
            //builder.HasMany(x => x.KeywordArticles).WithOne(x => x.Keyword).HasForeignKey(x => x.KeywordID);
        }
    }
}
