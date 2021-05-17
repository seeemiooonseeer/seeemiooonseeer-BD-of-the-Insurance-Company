using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_of_the_Insurance_Company.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PoliciesID",
                table: "Staff",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Policies_ID = table.Column<long>(nullable: false),
                    Start_date = table.Column<DateTime>(nullable: false),
                    End_date = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Payment_amount = table.Column<int>(nullable: false),
                    Payment_mark = table.Column<string>(nullable: true),
                    End_mark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_ID = table.Column<long>(nullable: false),
                    Full_name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Passport_data = table.Column<string>(nullable: true),
                    PoliciesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Policies_PoliciesID",
                        column: x => x.PoliciesID,
                        principalTable: "Policies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Policy_type",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Policy_type_ID = table.Column<long>(nullable: false),
                    Policy_type_name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Conditions = table.Column<string>(nullable: true),
                    PoliciesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy_type", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Policy_type_Policies_PoliciesID",
                        column: x => x.PoliciesID,
                        principalTable: "Policies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Groups_ID = table.Column<long>(nullable: false),
                    Groups_name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClientID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Groups_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Risks_ID = table.Column<long>(nullable: false),
                    Risks_name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Average_Probability = table.Column<int>(nullable: false),
                    Policy_typeID = table.Column<long>(nullable: true),
                    Policy_typeID1 = table.Column<long>(nullable: true),
                    Policy_typeID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Risks_Policy_type_Policy_typeID",
                        column: x => x.Policy_typeID,
                        principalTable: "Policy_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Risks_Policy_type_Policy_typeID1",
                        column: x => x.Policy_typeID1,
                        principalTable: "Policy_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Risks_Policy_type_Policy_typeID2",
                        column: x => x.Policy_typeID2,
                        principalTable: "Policy_type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PoliciesID",
                table: "Staff",
                column: "PoliciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_PoliciesID",
                table: "Client",
                column: "PoliciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ClientID",
                table: "Groups",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_type_PoliciesID",
                table: "Policy_type",
                column: "PoliciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_Policy_typeID",
                table: "Risks",
                column: "Policy_typeID");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_Policy_typeID1",
                table: "Risks",
                column: "Policy_typeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_Policy_typeID2",
                table: "Risks",
                column: "Policy_typeID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Policies_PoliciesID",
                table: "Staff",
                column: "PoliciesID",
                principalTable: "Policies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Policies_PoliciesID",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Policy_type");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PoliciesID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PoliciesID",
                table: "Staff");
        }
    }
}
