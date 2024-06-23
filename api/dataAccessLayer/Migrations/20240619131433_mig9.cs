using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "postId",
                table: "recipeTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "postTables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_postTables_RecipeId",
                table: "postTables",
                column: "RecipeId",
                unique: true,
                filter: "[RecipeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_postTables_recipeTables_RecipeId",
                table: "postTables",
                column: "RecipeId",
                principalTable: "recipeTables",
                principalColumn: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postTables_recipeTables_RecipeId",
                table: "postTables");

            migrationBuilder.DropIndex(
                name: "IX_postTables_RecipeId",
                table: "postTables");

            migrationBuilder.DropColumn(
                name: "postId",
                table: "recipeTables");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "postTables");
        }
    }
}
