using Microsoft.EntityFrameworkCore.Migrations;

namespace Article.Persistence.EF.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryKeyword_Categories_CategoriesCategoryID",
                table: "CategoryKeyword");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryKeyword_Keywords_KeywordsKeywordID",
                table: "CategoryKeyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryKeyword",
                table: "CategoryKeyword");

            migrationBuilder.RenameTable(
                name: "CategoryKeyword",
                newName: "CategoryKeywords");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryKeyword_KeywordsKeywordID",
                table: "CategoryKeywords",
                newName: "IX_CategoryKeywords_KeywordsKeywordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryKeywords",
                table: "CategoryKeywords",
                columns: new[] { "CategoriesCategoryID", "KeywordsKeywordID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryKeywords_Categories_CategoriesCategoryID",
                table: "CategoryKeywords",
                column: "CategoriesCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryKeywords_Keywords_KeywordsKeywordID",
                table: "CategoryKeywords",
                column: "KeywordsKeywordID",
                principalTable: "Keywords",
                principalColumn: "KeywordID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryKeywords_Categories_CategoriesCategoryID",
                table: "CategoryKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryKeywords_Keywords_KeywordsKeywordID",
                table: "CategoryKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryKeywords",
                table: "CategoryKeywords");

            migrationBuilder.RenameTable(
                name: "CategoryKeywords",
                newName: "CategoryKeyword");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryKeywords_KeywordsKeywordID",
                table: "CategoryKeyword",
                newName: "IX_CategoryKeyword_KeywordsKeywordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryKeyword",
                table: "CategoryKeyword",
                columns: new[] { "CategoriesCategoryID", "KeywordsKeywordID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryKeyword_Categories_CategoriesCategoryID",
                table: "CategoryKeyword",
                column: "CategoriesCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryKeyword_Keywords_KeywordsKeywordID",
                table: "CategoryKeyword",
                column: "KeywordsKeywordID",
                principalTable: "Keywords",
                principalColumn: "KeywordID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
