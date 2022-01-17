using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApplication.Migrations
{
    public partial class ManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoryPostsId = table.Column<int>(type: "int", nullable: false),
                    PostCategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoryPostsId, x.PostCategoriesId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Categories_PostCategoriesId",
                        column: x => x.PostCategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Posts_CategoryPostsId",
                        column: x => x.CategoryPostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostCategoriesId",
                table: "CategoryPost",
                column: "PostCategoriesId");
        }
    }
}
