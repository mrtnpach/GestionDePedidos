using Microsoft.EntityFrameworkCore.Migrations;

namespace Pav2022.P2.Datos.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineasPedido_Pedidos_PedidoId",
                table: "LineasPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_LineasPedido_Pedidos_PedidoId",
                table: "LineasPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineasPedido_Pedidos_PedidoId",
                table: "LineasPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_LineasPedido_Pedidos_PedidoId",
                table: "LineasPedido",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
