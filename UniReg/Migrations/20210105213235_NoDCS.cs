using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniReg.Migrations
{
    public partial class NoDCS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentCourseStudent");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CourseStudent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CourseStudent");

            migrationBuilder.CreateTable(
                name: "DepartmentCourseStudent",
                columns: table => new
                {
                    DepartmentCourseStudentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    CourseStudentId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCourseStudent", x => x.DepartmentCourseStudentId);
                    table.ForeignKey(
                        name: "FK_DepartmentCourseStudent_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentCourseStudent_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentCourseStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourseStudent_CourseId",
                table: "DepartmentCourseStudent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourseStudent_DepartmentId",
                table: "DepartmentCourseStudent",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourseStudent_StudentId",
                table: "DepartmentCourseStudent",
                column: "StudentId");
        }
    }
}
