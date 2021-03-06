using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d7e9dd43-9d15-4c7d-81d2-623aa0bb5f5a", "a0c39daa-294e-4517-a35d-d9ba5f9fe7fc", "Manager", "MANAGER" },
                    { "624285d4-9e40-4083-aa21-61cfec2f22da", "46dacdc3-b7f0-47cd-8d6a-d31ca037c0d4", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624285d4-9e40-4083-aa21-61cfec2f22da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7e9dd43-9d15-4c7d-81d2-623aa0bb5f5a");
        }
    }
}
