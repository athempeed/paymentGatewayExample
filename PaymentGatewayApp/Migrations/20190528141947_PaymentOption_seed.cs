using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentGatewayApp.Migrations
{
    public partial class PaymentOption_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Online Banking" });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Gateway Wallet" });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Debit/Credit Card" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentOptions",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
