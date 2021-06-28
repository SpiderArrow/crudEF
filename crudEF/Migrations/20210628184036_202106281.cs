using Microsoft.EntityFrameworkCore.Migrations;

namespace crudEF.Migrations
{
    public partial class _202106281 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "PROVEEDORES",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "PRODUCTOS",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "PROVEEDORES");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "PRODUCTOS");
        }
    }
}
