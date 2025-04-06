using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppSAT.Migrations
{
    /// <inheritdoc />
    public partial class AgregarUsoCFDI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsoCFDI",
                table: "Receptores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsoCFDI",
                table: "Receptores");
        }
    }
}
