using Microsoft.EntityFrameworkCore.Migrations;

namespace CvMaker.DataAccess.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserInformationId",
                table: "Nationalities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Departments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UniversityDepartments",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    FacultyFakultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityDepartments", x => new { x.UniversityId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_UniversityDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityDepartments_Faculties_FacultyFakultyId",
                        column: x => x.FacultyFakultyId,
                        principalTable: "Faculties",
                        principalColumn: "FakultyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UniversityDepartments_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "UniversityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInformations_UserId",
                table: "UserInformations",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_UserInformationId",
                table: "Nationalities",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_DepartmentId",
                table: "UniversityDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityDepartments_FacultyFakultyId",
                table: "UniversityDepartments",
                column: "FacultyFakultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FakultyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_UserInformations_UserInformationId",
                table: "Nationalities",
                column: "UserInformationId",
                principalTable: "UserInformations",
                principalColumn: "UserInformationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_UserInformations_UserInformationId",
                table: "Nationalities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations");

            migrationBuilder.DropTable(
                name: "UniversityDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UserInformations_UserId",
                table: "UserInformations");

            migrationBuilder.DropIndex(
                name: "IX_Nationalities_UserInformationId",
                table: "Nationalities");

            migrationBuilder.DropIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserInformations");

            migrationBuilder.DropColumn(
                name: "UserInformationId",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Departments");
        }
    }
}
