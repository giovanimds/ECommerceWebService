using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWebService.Migrations
{
    public partial class UsuarioCarrinho2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId1",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CarrinhoId1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CarrinhoId1",
                table: "Usuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CarrinhoId",
                table: "Usuarios",
                column: "CarrinhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId",
                table: "Usuarios",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "CarrinhoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CarrinhoId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId1",
                table: "Usuarios",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CarrinhoId1",
                table: "Usuarios",
                column: "CarrinhoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId1",
                table: "Usuarios",
                column: "CarrinhoId1",
                principalTable: "Carrinhos",
                principalColumn: "CarrinhoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
