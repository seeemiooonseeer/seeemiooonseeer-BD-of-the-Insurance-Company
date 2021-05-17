using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_of_the_Insurance_Company.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PositionID",
                table: "Staff",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RisksID1",
                table: "Policy_type",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RisksID2",
                table: "Policy_type",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RisksID3",
                table: "Policy_type",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientsID",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Policy_typeID",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "Policies",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "GroupsID",
                table: "Client",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RisksID1",
                table: "Policy_type");

            migrationBuilder.DropColumn(
                name: "RisksID2",
                table: "Policy_type");

            migrationBuilder.DropColumn(
                name: "RisksID3",
                table: "Policy_type");

            migrationBuilder.DropColumn(
                name: "ClientsID",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "Policy_typeID",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Policies");

            migrationBuilder.DropColumn(
                name: "GroupsID",
                table: "Client");
        }
    }
}
