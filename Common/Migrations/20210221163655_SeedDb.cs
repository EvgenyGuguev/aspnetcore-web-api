using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("a1db62c5-663b-45c6-a734-9a7659cf26a2"), 18, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Nathanial Haag", "Administrator" },
                    { new Guid("773e8aff-7831-43da-b90b-c7910934ae7b"), 34, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Tyson Hand", "Administrator" },
                    { new Guid("79832fc0-a1cb-494b-96ac-1aed6785d346"), 28, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Sim Smith", "Software developer" },
                    { new Guid("63c1e54c-580a-4324-8dd4-e07bb912bd98"), 59, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Freeda Stracke", "Administrator" },
                    { new Guid("0b063015-ba57-43a8-956a-56ac7e4b7571"), 43, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Presley Pfeffer", "Administrator" },
                    { new Guid("abaefe76-32c7-4c22-b9a2-2a1895208993"), 43, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Emanuel Crona", "Software developer" },
                    { new Guid("6f4e74aa-1c88-430b-95dc-3f32d43773d0"), 35, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Jon Reynolds", "Administrator" },
                    { new Guid("18e22b09-04ca-4164-a908-674dca01f648"), 46, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Robin Ryan", "Administrator" },
                    { new Guid("5f9c6113-3ab8-496f-86ba-06341d03c128"), 54, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Stephan Kutch", "Administrator" },
                    { new Guid("2d7d7409-4caa-4eb5-ad11-8e71b7b543d3"), 39, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Jacynthe Cassin", "Administrator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0b063015-ba57-43a8-956a-56ac7e4b7571"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("18e22b09-04ca-4164-a908-674dca01f648"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("2d7d7409-4caa-4eb5-ad11-8e71b7b543d3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("5f9c6113-3ab8-496f-86ba-06341d03c128"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("63c1e54c-580a-4324-8dd4-e07bb912bd98"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6f4e74aa-1c88-430b-95dc-3f32d43773d0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("773e8aff-7831-43da-b90b-c7910934ae7b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("79832fc0-a1cb-494b-96ac-1aed6785d346"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a1db62c5-663b-45c6-a734-9a7659cf26a2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("abaefe76-32c7-4c22-b9a2-2a1895208993"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
