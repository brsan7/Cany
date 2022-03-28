using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopCany.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Funcoes",
                columns: table => new
                {
                    ID_FcnModData = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Funcao = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    DescricaoFcn = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ModProgramador = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ModEstavel = table.Column<bool>(type: "INTEGER", nullable: false),
                    Snippet = table.Column<string>(type: "TEXT", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Funcoes", x => x.ID_FcnModData);
                });

            migrationBuilder.CreateTable(
                name: "TB_Linguagens",
                columns: table => new
                {
                    ID_Linguagem = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    DescricaoLang = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Linguagens", x => x.ID_Linguagem);
                });

            migrationBuilder.CreateTable(
                name: "TB_Bibliotecas",
                columns: table => new
                {
                    ID_Biblioteca = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID_Linguagem = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ID_FcnModData = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Biblioteca = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    DescricaoLib = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Bibliotecas", x => x.ID_Biblioteca);
                    table.ForeignKey(
                        name: "FK_TB_Bibliotecas_TB_Funcoes_ID_FcnModData",
                        column: x => x.ID_FcnModData,
                        principalTable: "TB_Funcoes",
                        principalColumn: "ID_FcnModData",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_Bibliotecas_TB_Linguagens_ID_Linguagem",
                        column: x => x.ID_Linguagem,
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
