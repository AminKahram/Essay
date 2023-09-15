using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Persistence.EF.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleKeyword_Articles_ArticlesArticleID",
                table: "ArticleKeyword");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleKeyword_Keywords_KeywordsKeywordID",
                table: "ArticleKeyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleKeyword",
                table: "ArticleKeyword");

            migrationBuilder.RenameTable(
                name: "ArticleKeyword",
                newName: "ArticleKeywords");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleKeyword_KeywordsKeywordID",
                table: "ArticleKeywords",
                newName: "IX_ArticleKeywords_KeywordsKeywordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleKeywords",
                table: "ArticleKeywords",
                columns: new[] { "ArticlesArticleID", "KeywordsKeywordID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleKeywords_Articles_ArticlesArticleID",
                table: "ArticleKeywords",
                column: "ArticlesArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleKeywords_Keywords_KeywordsKeywordID",
                table: "ArticleKeywords",
                column: "KeywordsKeywordID",
                principalTable: "Keywords",
                principalColumn: "KeywordID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleKeywords_Articles_ArticlesArticleID",
                table: "ArticleKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleKeywords_Keywords_KeywordsKeywordID",
                table: "ArticleKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleKeywords",
                table: "ArticleKeywords");

            migrationBuilder.RenameTable(
                name: "ArticleKeywords",
                newName: "ArticleKeyword");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleKeywords_KeywordsKeywordID",
                table: "ArticleKeyword",
                newName: "IX_ArticleKeyword_KeywordsKeywordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleKeyword",
                table: "ArticleKeyword",
                columns: new[] { "ArticlesArticleID", "KeywordsKeywordID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleKeyword_Articles_ArticlesArticleID",
                table: "ArticleKeyword",
                column: "ArticlesArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleKeyword_Keywords_KeywordsKeywordID",
                table: "ArticleKeyword",
                column: "KeywordsKeywordID",
                principalTable: "Keywords",
                principalColumn: "KeywordID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
