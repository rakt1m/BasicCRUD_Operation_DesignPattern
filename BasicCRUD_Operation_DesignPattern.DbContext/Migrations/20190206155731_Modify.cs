using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicCRUD_Operation_DesignPattern.DbContext.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Departments_DepartmentId",
                table: "StudentInfos");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "StudentInfos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Departments_DepartmentId",
                table: "StudentInfos",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Departments_DepartmentId",
                table: "StudentInfos");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "StudentInfos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Departments_DepartmentId",
                table: "StudentInfos",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
