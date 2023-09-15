﻿// <auto-generated />
using System;
using Article.Persistence.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Article.Persistence.EF.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("20220218072752_m7")]
    partial class m7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Article.DomainModel.Models.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ArticleImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ArticleImageName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ArticleSubject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("SmallDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ArticleID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Article.DomainModel.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Article.DomainModel.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CategoryID");

                    b.HasIndex("ParentID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Article.DomainModel.Models.Keyword", b =>
                {
                    b.Property<int>("KeywordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeywordName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("KeywordID");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("ArticleAuthor", b =>
                {
                    b.Property<int>("ArticlesArticleID")
                        .HasColumnType("int");

                    b.Property<int>("AuthorsAuthorID")
                        .HasColumnType("int");

                    b.HasKey("ArticlesArticleID", "AuthorsAuthorID");

                    b.HasIndex("AuthorsAuthorID");

                    b.ToTable("ArticleAuthors");
                });

            modelBuilder.Entity("ArticleKeyword", b =>
                {
                    b.Property<int>("ArticlesArticleID")
                        .HasColumnType("int");

                    b.Property<int>("KeywordsKeywordID")
                        .HasColumnType("int");

                    b.HasKey("ArticlesArticleID", "KeywordsKeywordID");

                    b.HasIndex("KeywordsKeywordID");

                    b.ToTable("ArticleKeywords");
                });

            modelBuilder.Entity("CategoryKeyword", b =>
                {
                    b.Property<int>("CategoriesCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("KeywordsKeywordID")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryID", "KeywordsKeywordID");

                    b.HasIndex("KeywordsKeywordID");

                    b.ToTable("CategoryKeywords");
                });

            modelBuilder.Entity("Article.DomainModel.Models.Article", b =>
                {
                    b.HasOne("Article.DomainModel.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Article.DomainModel.Models.Category", b =>
                {
                    b.HasOne("Article.DomainModel.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentID");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ArticleAuthor", b =>
                {
                    b.HasOne("Article.DomainModel.Models.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Article.DomainModel.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleKeyword", b =>
                {
                    b.HasOne("Article.DomainModel.Models.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Article.DomainModel.Models.Keyword", null)
                        .WithMany()
                        .HasForeignKey("KeywordsKeywordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryKeyword", b =>
                {
                    b.HasOne("Article.DomainModel.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Article.DomainModel.Models.Keyword", null)
                        .WithMany()
                        .HasForeignKey("KeywordsKeywordID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Article.DomainModel.Models.Category", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
