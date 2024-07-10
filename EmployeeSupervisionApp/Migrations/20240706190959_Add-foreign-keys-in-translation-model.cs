using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSupervisionApp.Migrations
{
    /// <inheritdoc />
    public partial class Addforeignkeysintranslationmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementKey",
                table: "Translations");

            migrationBuilder.AddColumn<int>(
                name: "ElementKeyID",
                table: "Translations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_ElementKeyID",
                table: "Translations",
                column: "ElementKeyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_ElementKeys_ElementKeyID",
                table: "Translations",
                column: "ElementKeyID",
                principalTable: "ElementKeys",
                principalColumn: "ElementKeyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_ElementKeys_ElementKeyID",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_ElementKeyID",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "ElementKeyID",
                table: "Translations");

            migrationBuilder.AddColumn<string>(
                name: "ElementKey",
                table: "Translations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
