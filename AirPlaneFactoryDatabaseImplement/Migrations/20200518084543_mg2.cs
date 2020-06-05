using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPlaneFactoryDatabaseImplement.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImplementerFIO",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImplementerId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Implementer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImplementerFIO = table.Column<string>(nullable: true),
                    WorkTime = table.Column<int>(nullable: false),
                    PauseTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Implementer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ImplementerId",
                table: "Orders",
                column: "ImplementerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Implementer_ImplementerId",
                table: "Orders",
                column: "ImplementerId",
                principalTable: "Implementer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Implementer_ImplementerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Implementer");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ImplementerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ImplementerFIO",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ImplementerId",
                table: "Orders");
        }
    }
}
