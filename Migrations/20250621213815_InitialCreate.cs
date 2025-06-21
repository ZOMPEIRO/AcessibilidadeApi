using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrabalhoTCC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ACESSIBILIDADE",
                columns: table => new
                {
                    idAcessibilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    modoContraste = table.Column<bool>(type: "bit", nullable: false),
                    tamanhoFonte = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    alertaSonoro = table.Column<bool>(type: "bit", nullable: false),
                    vibração = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ACESSIBILIDADE", x => x.idAcessibilidade);
                });

            migrationBuilder.InsertData(
                table: "TB_ACESSIBILIDADE",
                columns: new[] { "idAcessibilidade", "alertaSonoro", "idUsuario", "modoContraste", "tamanhoFonte", "vibração" },
                values: new object[,]
                {
                    { 1, false, 1, true, "45", true },
                    { 2, true, 2, true, "45", true },
                    { 3, true, 3, false, "45", true },
                    { 4, true, 4, false, "45", false },
                    { 5, true, 5, false, "45", false },
                    { 6, true, 6, false, "45", true },
                    { 7, true, 7, true, "45", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ACESSIBILIDADE");
        }
    }
}
