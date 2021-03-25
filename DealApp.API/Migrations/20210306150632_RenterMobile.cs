using Microsoft.EntityFrameworkCore.Migrations;

namespace DealApp.API.Migrations
{
    public partial class RenterMobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MobileNo1",
                table: "Renters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MobileNo2",
                table: "Renters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNo1",
                table: "Renters");

            migrationBuilder.DropColumn(
                name: "MobileNo2",
                table: "Renters");
        }
    }
}
