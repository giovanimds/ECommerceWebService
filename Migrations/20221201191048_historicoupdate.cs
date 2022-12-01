using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWebService.Migrations
{
    public partial class historicoupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Produtos_ProdutoId",
                table: "Historico");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Historico",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Historico_Produtos_ProdutoId",
                table: "Historico",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historico_Produtos_ProdutoId",
                table: "Historico");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Historico",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
