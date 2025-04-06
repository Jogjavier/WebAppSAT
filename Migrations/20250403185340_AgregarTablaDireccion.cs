using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppSAT.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablaDireccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DireccionesReceptores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumExt = table.Column<int>(type: "int", nullable: false),
                    NumInt = table.Column<int>(type: "int", nullable: false),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    ReceptorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionesReceptores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DireccionesReceptores_Receptores_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Receptores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DireccionesReceptores_ReceptorId",
                table: "DireccionesReceptores",
                column: "ReceptorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DireccionesReceptores");
        }
    }
}
