using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Authenticateservice.Migrations
{
    public partial class authmig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timeslot",
                table: "Training",
                newName: "timeslot");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Training",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Training",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Timeslot",
                table: "Mentor",
                newName: "timeslot");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Mentor",
                newName: "skills");

            migrationBuilder.RenameColumn(
                name: "Mobilenumber",
                table: "Mentor",
                newName: "mobilenumber");

            migrationBuilder.RenameColumn(
                name: "Experiance",
                table: "Mentor",
                newName: "experiance");

            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "Mentor",
                newName: "availability");

            migrationBuilder.AlterColumn<long>(
                name: "mobilenumber",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timeslot",
                table: "Training",
                newName: "Timeslot");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Training",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Training",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "timeslot",
                table: "Mentor",
                newName: "Timeslot");

            migrationBuilder.RenameColumn(
                name: "skills",
                table: "Mentor",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "mobilenumber",
                table: "Mentor",
                newName: "Mobilenumber");

            migrationBuilder.RenameColumn(
                name: "experiance",
                table: "Mentor",
                newName: "Experiance");

            migrationBuilder.RenameColumn(
                name: "availability",
                table: "Mentor",
                newName: "Availability");

            migrationBuilder.AlterColumn<int>(
                name: "Mobilenumber",
                table: "Mentor",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
