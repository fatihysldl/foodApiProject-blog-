using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postTables_recipeTables_recipeTableRecipeId",
                table: "postTables");

            migrationBuilder.DropIndex(
                name: "IX_postTables_recipeTableRecipeId",
                table: "postTables");

            migrationBuilder.DropColumn(
                name: "recipeTableRecipeId",
                table: "postTables");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "recipeTableRecipeId",
                table: "postTables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_postTables_recipeTableRecipeId",
                table: "postTables",
                column: "recipeTableRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_postTables_recipeTables_recipeTableRecipeId",
                table: "postTables",
                column: "recipeTableRecipeId",
                principalTable: "recipeTables",
                principalColumn: "RecipeId");
        }
    }
}
