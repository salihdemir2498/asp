using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLesson.Migrations
{
    public partial class Mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons");

            migrationBuilder.DropIndex(
                name: "IX_StudentLessons_StudentId",
                table: "StudentLessons");

            migrationBuilder.AlterColumn<int>(
                name: "StudentLessonId",
                table: "StudentLessons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons",
                columns: new[] { "StudentId", "LessonId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons");

            migrationBuilder.AlterColumn<int>(
                name: "StudentLessonId",
                table: "StudentLessons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentLessons",
                table: "StudentLessons",
                column: "StudentLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessons_StudentId",
                table: "StudentLessons",
                column: "StudentId");
        }
    }
}
