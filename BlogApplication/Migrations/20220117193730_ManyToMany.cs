using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApplication.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPost");
        }
    }
}
