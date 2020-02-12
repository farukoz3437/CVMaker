using Microsoft.EntityFrameworkCore.Migrations;

namespace CvMaker.DataAccess.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "DriverLisances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLisances_UserId",
                table: "DriverLisances",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLisances_Users_UserId",
                table: "DriverLisances",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLisances_Users_UserId",
                table: "DriverLisances");

            migrationBuilder.DropIndex(
                name: "IX_DriverLisances_UserId",
                table: "DriverLisances");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DriverLisances");
        }
    }
}
