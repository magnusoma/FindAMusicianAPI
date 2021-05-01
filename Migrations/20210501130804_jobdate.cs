using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FindAMusicianAPI.Migrations
{
    public partial class jobdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtistID",
                table: "Artist",
                newName: "ArtistId");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Job",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artist",
                newName: "ArtistID");
        }
    }
}
