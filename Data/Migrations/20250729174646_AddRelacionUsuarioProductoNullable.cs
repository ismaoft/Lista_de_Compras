using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaDeCompras.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionUsuarioProductoNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Producto",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_UsuarioId",
                table: "Producto",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_AspNetUsers_UsuarioId",
                table: "Producto",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_AspNetUsers_UsuarioId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_UsuarioId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Producto");
        }
    }
}
