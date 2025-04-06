using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppSAT.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDireccionReceptor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DireccionReceptorId",
                table: "Receptores",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumInt",
                table: "DireccionesReceptores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumExt",
                table: "DireccionesReceptores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CodigoPostal",
                table: "DireccionesReceptores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DireccionReceptorId",
                table: "Receptores");

            migrationBuilder.AlterColumn<int>(
                name: "NumInt",
                table: "DireccionesReceptores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumExt",
                table: "DireccionesReceptores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoPostal",
                table: "DireccionesReceptores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
