using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseDemo.EF.Migrations
{
    public partial class addUniqueConstraintsToCourseReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Reference",
                table: "Courses",
                column: "Reference",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_Reference",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
