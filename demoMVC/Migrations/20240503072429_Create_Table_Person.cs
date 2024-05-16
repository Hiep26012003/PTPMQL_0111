using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Person",
                newName: "old");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "old",
                table: "Person",
                newName: "Address");
        }
    }
}
