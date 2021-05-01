using Microsoft.EntityFrameworkCore.Migrations;

namespace FindAMusicianAPI.Migrations
{
    public partial class NewTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicanType",
                table: "MusicanType");

            migrationBuilder.RenameTable(
                name: "MusicanType",
                newName: "Job");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "MusicanType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicanType",
                table: "MusicanType",
                column: "Id");
        }
    }
}
