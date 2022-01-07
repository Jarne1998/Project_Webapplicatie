using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer_Project.Migrations
{
    public partial class ChangeCustomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                schema: "webApp",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                schema: "webApp",
                table: "AspNetUsers");
        }
    }
}
