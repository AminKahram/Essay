using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Persistence.EF.Migrations
{
    public partial class m11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleAuthors_Articles_ArticleID",
                table: "ArticleAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleAuthors_Authors_AuthorID",
                table: "ArticleAuthors");

            migrationBuilder.RenameColumn(
                name: "ArticleID",
                table: "ArticleAuthors",
                newName: "AuthorsAuthorID");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "ArticleAuthors",
                newName: "ArticlesArticleID");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleAuthors_ArticleID",
                table: "ArticleAuthors",
                newName: "IX_ArticleAuthors_AuthorsAuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleAuthors_Articles_ArticlesArticleID",
                table: "ArticleAuthors",
                column: "ArticlesArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleAuthors_Authors_AuthorsAuthorID",
                table: "ArticleAuthors",
                column: "AuthorsAuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleAuthors_Articles_ArticlesArticleID",
                table: "ArticleAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleAuthors_Authors_AuthorsAuthorID",
                table: "ArticleAuthors");

            migrationBuilder.RenameColumn(
                name: "AuthorsAuthorID",
                table: "ArticleAuthors",
                newName: "ArticleID");

            migrationBuilder.RenameColumn(
                name: "ArticlesArticleID",
                table: "ArticleAuthors",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleAuthors_AuthorsAuthorID",
                table: "ArticleAuthors",
                newName: "IX_ArticleAuthors_ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleAuthors_Articles_ArticleID",
                table: "ArticleAuthors",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleAuthors_Authors_AuthorID",
                table: "ArticleAuthors",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
