using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelier.Api.DataAccessLayer.Migrations
{
    public partial class latest_migration_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Subscribes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "SenderEMail",
                table: "SendMessages",
                newName: "SenderEmail");

            migrationBuilder.RenameColumn(
                name: "ReceiverMail",
                table: "SendMessages",
                newName: "ReceiverEmail");

            migrationBuilder.RenameColumn(
                name: "GuestSurname",
                table: "Guests",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "GuestName",
                table: "Guests",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Bookings",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Subscribes",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "SenderEmail",
                table: "SendMessages",
                newName: "SenderEMail");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmail",
                table: "SendMessages",
                newName: "ReceiverMail");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Guests",
                newName: "GuestSurname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Guests",
                newName: "GuestName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "EMail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Bookings",
                newName: "EMail");
        }
    }
}
