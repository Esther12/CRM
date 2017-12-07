using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CRM2.Migrations
{
    public partial class SecondCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Inv_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Inv_amount = table.Column<string>(type: "TEXT", nullable: true),
                    Inv_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Inv_des = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_InvoiceId", x => x.Inv_ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cus_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cus_city = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_country = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_email = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_fname = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_lname = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_phone = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_pro = table.Column<string>(type: "TEXT", nullable: true),
                    Cus_street = table.Column<string>(type: "TEXT", nullable: true),
                    Inv_ID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_CustomerId", x => x.Cus_ID);
                    table.ForeignKey(
                        name: "ForeignKey_Customer_Invoice",
                        column: x => x.Inv_ID,
                        principalTable: "Invoices",
                        principalColumn: "Inv_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cus_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Emp_email = table.Column<string>(type: "TEXT", nullable: true),
                    Emp_fname = table.Column<string>(type: "TEXT", nullable: true),
                    Emp_lname = table.Column<string>(type: "TEXT", nullable: true),
                    Emp_phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_EmployeeId", x => x.Emp_ID);
                    table.ForeignKey(
                        name: "ForeignKey_Employee_Customer",
                        column: x => x.Cus_ID,
                        principalTable: "Customers",
                        principalColumn: "Cus_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Inv_ID",
                table: "Customers",
                column: "Inv_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Cus_ID",
                table: "Employees",
                column: "Cus_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
