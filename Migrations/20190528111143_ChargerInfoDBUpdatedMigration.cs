using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChargerInfo.API.Migrations
{
    public partial class ChargerInfoDBUpdatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sessions_chargers_Chargerid",
                table: "sessions");

            migrationBuilder.DropIndex(
                name: "IX_sessions_Chargerid",
                table: "sessions");

            migrationBuilder.DropColumn(
                name: "Chargerid",
                table: "sessions");

            migrationBuilder.DropColumn(
                name: "sessionName",
                table: "sessions");

            migrationBuilder.AddColumn<DateTime>(
                name: "sessionStartTime",
                table: "sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "sessionStopTime",
                table: "sessions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "sessions",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "chargerStationType",
                table: "chargers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sessionStartTime",
                table: "sessions");

            migrationBuilder.DropColumn(
                name: "sessionStopTime",
                table: "sessions");

            migrationBuilder.DropColumn(
                name: "status",
                table: "sessions");

            migrationBuilder.AddColumn<int>(
                name: "Chargerid",
                table: "sessions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sessionName",
                table: "sessions",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "chargerStationType",
                table: "chargers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_sessions_Chargerid",
                table: "sessions",
                column: "Chargerid");

            migrationBuilder.AddForeignKey(
                name: "FK_sessions_chargers_Chargerid",
                table: "sessions",
                column: "Chargerid",
                principalTable: "chargers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
