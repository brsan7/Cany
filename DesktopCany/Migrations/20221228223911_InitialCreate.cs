using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopCany.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Funcoes",
                columns: table => new
                {
                    IDFcnModData = table.Column<string>(name: "ID_FcnModData", type: "TEXT", maxLength: 20, nullable: false),
                    Funcao = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DescricaoFcn = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ModProgramador = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ModEstavel = table.Column<bool>(type: "INTEGER", nullable: false),
                    Snippet = table.Column<string>(type: "TEXT", maxLength: 8000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Funcoes", x => x.IDFcnModData);
                });

            migrationBuilder.CreateTable(
                name: "TB_Linguagens",
                columns: table => new
                {
                    IDLinguagem = table.Column<string>(name: "ID_Linguagem", type: "TEXT", maxLength: 30, nullable: false),
                    DescricaoLang = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Linguagens", x => x.IDLinguagem);
                });

            migrationBuilder.CreateTable(
                name: "TB_Bibliotecas",
                columns: table => new
                {
                    IDBiblioteca = table.Column<long>(name: "ID_Biblioteca", type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDLinguagem = table.Column<string>(name: "ID_Linguagem", type: "TEXT", maxLength: 30, nullable: false),
                    IDFcnModData = table.Column<string>(name: "ID_FcnModData", type: "TEXT", maxLength: 20, nullable: false),
                    Biblioteca = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DescricaoLib = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Bibliotecas", x => x.IDBiblioteca);
                    table.ForeignKey(
                        name: "FK_TB_Bibliotecas_TB_Funcoes_ID_FcnModData",
                        column: x => x.IDFcnModData,
                        principalTable: "TB_Funcoes",
                        principalColumn: "ID_FcnModData",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_Bibliotecas_TB_Linguagens_ID_Linguagem",
                        column: x => x.IDLinguagem,
                        principalTable: "TB_Linguagens",
                        principalColumn: "ID_Linguagem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Bibliotecas_ID_FcnModData",
                table: "TB_Bibliotecas",
                column: "ID_FcnModData");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Bibliotecas_ID_Linguagem",
                table: "TB_Bibliotecas",
                column: "ID_Linguagem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Bibliotecas");

            migrationBuilder.DropTable(
                name: "TB_Funcoes");

            migrationBuilder.DropTable(
                name: "TB_Linguagens");
        }
    }
}
