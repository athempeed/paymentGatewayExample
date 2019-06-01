using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentGatewayApp.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banks",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Maybank" },
                    { 2, "CIMB Bank" },
                    { 3, "Public Bank Berhad" },
                    { 4, "RHB Bank" },
                    { 5, "Hong Leong Bank" },
                    { 6, "OCBC Bank Malaysia" },
                    { 7, "HSBC Bank Malaysia" },
                    { 8, "CitiBank Malaysia" },
                    { 9, "Bank Muamalat Malaysia Berhad" },
                    { 10, "Alliance Bank" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Banks",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
