using Microsoft.EntityFrameworkCore.Migrations;

namespace CvMaker.DataAccess.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityDepartments_Departments_DepartmentId",
                table: "UniversityDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityDepartments_Departments_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
