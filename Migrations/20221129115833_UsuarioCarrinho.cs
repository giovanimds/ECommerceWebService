using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceWebService.Migrations
{
    public partial class UsuarioCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoId",
                table: "Usuarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Carrinhos_CarrinhoId1",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CarrinhoId1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CarrinhoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CarrinhoId1",
                table: "Usuarios");
        }
    }
}
