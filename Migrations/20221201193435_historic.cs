using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWebService.Migrations
{
    public partial class historic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Produtos_ProdutoId",
                table: "Historico");

            migrationBuilder.DropIndex(
                name: "IX_Historico_ProdutoId",
                table: "Historico");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Historico");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Historico",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Historico_ProdutoId",
                table: "Historico",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Produtos_ProdutoId",
                table: "Historico",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
