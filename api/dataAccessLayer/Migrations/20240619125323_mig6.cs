using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "recipeTableRecipeId",
                table: "postTables",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "recipeTables",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeHeader = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RecipeValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeIngredients = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ımagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipeTables", x => x.RecipeId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postTables_recipeTables_recipeTableRecipeId",
                table: "postTables");

            migrationBuilder.DropTable(
                name: "recipeTables");

            migrationBuilder.DropIndex(
                name: "IX_postTables_recipeTableRecipeId",
                table: "postTables");

            migrationBuilder.DropColumn(
                name: "recipeTableRecipeId",
                table: "postTables");
        }
    }
}
