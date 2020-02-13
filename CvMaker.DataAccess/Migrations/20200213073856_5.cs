using Microsoft.EntityFrameworkCore.Migrations;

namespace CvMaker.DataAccess.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "UserUniversities");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "UserUniversities");

            migrationBuilder.CreateIndex(
                name: "IX_UserUniversities_UniversityId",
                table: "UserUniversities",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUniversities_Universities_UniversityId",
                table: "UserUniversities",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "UniversityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUniversities_Universities_UniversityId",
                table: "UserUniversities");

            migrationBuilder.DropIndex(
                name: "IX_UserUniversities_UniversityId",
                table: "UserUniversities");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "UserUniversities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "UserUniversities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
