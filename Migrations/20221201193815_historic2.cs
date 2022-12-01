using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWebService.Migrations
{
    public partial class historic2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Historico_ProdutoId",
                table: "Produtos");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "HistoricoProduto",
                columns: table => new
                {
                    HistoricosHistoricoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutosProdutoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoProduto", x => new { x.HistoricosHistoricoId, x.ProdutosProdutoId });
                    table.ForeignKey(
                        name: "FK_HistoricoProduto_Historico_HistoricosHistoricoId",
                        column: x => x.HistoricosHistoricoId,
                        principalTable: "Historico",
                        principalColumn: "HistoricoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoProduto_Produtos_ProdutosProdutoId",
                        column: x => x.ProdutosProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProduto_ProdutosProdutoId",
                table: "HistoricoProduto",
                column: "ProdutosProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoProduto");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Historico_ProdutoId",
                table: "Produtos",
                column: "ProdutoId",
                principalTable: "Historico",
                principalColumn: "HistoricoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
