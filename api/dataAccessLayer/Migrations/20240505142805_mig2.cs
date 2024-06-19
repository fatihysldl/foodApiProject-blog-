using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "authorId",
                table: "postTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_postTables_authorId",
                table: "postTables",
                column: "authorId");

            migrationBuilder.AddForeignKey(
                name: "FK_postTables_authorTables_authorId",
                table: "postTables",
                column: "authorId",
                principalTable: "authorTables",
                principalColumn: "authorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postTables_authorTables_authorId",
                table: "postTables");

            migrationBuilder.DropIndex(
                name: "IX_postTables_authorId",
                table: "postTables");

            migrationBuilder.DropColumn(
                name: "authorId",
                table: "postTables");
        }
    }
}
