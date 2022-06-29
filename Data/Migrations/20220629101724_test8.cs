using Microsoft.EntityFrameworkCore.Migrations;

namespace Asm1670.Data.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DaNang",
                column: "ConcurrencyStamp",
                value: "821469b5-7f1f-45e1-83a4-e56f92634a3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "9fed18b5-8000-48ad-a1d1-b7cd7140de83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "ac17e3b2-2b8f-41bc-a555-a8bf0f20dd50");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DaNang",
                column: "ConcurrencyStamp",
                value: "7201b466-7eb7-4f0f-8fa2-2e391baeb02c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HANOI",
                column: "ConcurrencyStamp",
                value: "0128b1a2-2996-4117-8427-06bd2b855036");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HCM",
                column: "ConcurrencyStamp",
                value: "d6d666bd-0b0a-4f96-9cbe-025ff2105142");
        }
    }
}
