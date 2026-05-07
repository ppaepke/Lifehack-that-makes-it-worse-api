using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeHacksThatMakesItWorseAPI.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LifeHacks_Category_categoryId",
                table: "LifeHacks");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "LifeHacks",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_LifeHacks_categoryId",
                table: "LifeHacks",
                newName: "IX_LifeHacks_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "LifeHack",
                table: "LifeHacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_LifeHacks_Category_CategoryId",
                table: "LifeHacks",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LifeHacks_Category_CategoryId",
                table: "LifeHacks");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "LifeHacks",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_LifeHacks_CategoryId",
                table: "LifeHacks",
                newName: "IX_LifeHacks_categoryId");

            migrationBuilder.AlterColumn<string>(
                name: "LifeHack",
                table: "LifeHacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LifeHacks_Category_categoryId",
                table: "LifeHacks",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
