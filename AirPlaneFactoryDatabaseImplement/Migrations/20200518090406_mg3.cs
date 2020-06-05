using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPlaneFactoryDatabaseImplement.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Implementer_ImplementerId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Implementer",
                table: "Implementer");

            migrationBuilder.RenameTable(
                name: "Implementer",
                newName: "Implementers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Implementers",
                table: "Implementers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Implementers_ImplementerId",
                table: "Orders",
                column: "ImplementerId",
                principalTable: "Implementers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Implementers_ImplementerId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Implementers",
                table: "Implementers");

            migrationBuilder.RenameTable(
                name: "Implementers",
                newName: "Implementer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Implementer",
                table: "Implementer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Implementer_ImplementerId",
                table: "Orders",
                column: "ImplementerId",
                principalTable: "Implementer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
